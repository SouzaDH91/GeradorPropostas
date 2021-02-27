using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace GeradorDePropostas
{
    public partial class frmMain : Form
    {
        string arquivoExcel = "";

        public frmMain()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DialogResult drResult = ofdLocalizaExcel.ShowDialog();

            if (drResult == DialogResult.OK)
            {
                tbArquivoExcel.Text = ofdLocalizaExcel.FileName;
                if (!string.IsNullOrEmpty(tbArquivoExcel.Text) && File.Exists(tbArquivoExcel.Text))
                {
                    arquivoExcel = tbArquivoExcel.Text;
                    Task.Factory.StartNew(() => CarregaDadosExcel());
                    CarregaDadosExcel();
                }
            }

        }

        private void CarregaDadosExcel()
        {
            try
            {
                Thread.Sleep(5000);
                DataTable dt = new DataTable();

                //pega a extensão do arquivo
                string Ext = Path.GetExtension(arquivoExcel);
                string connectionString = "";
                //verifica a versão do Excel pela extensão
                if (Ext == ".xls")
                { //para o  Excel 97-03    
                    connectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source =" + arquivoExcel + "; Extended Properties = 'Excel 8.0;HDR=YES'";
                }
                else if (Ext == ".xlsx")
                { //para o  Excel 07 e superior
                    connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source =" + arquivoExcel + "; Extended Properties = 'Excel 8.0;HDR=YES'";
                }
                OleDbConnection conn = new OleDbConnection(connectionString);
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
                cmd.Connection = conn;
                conn.Open();
                DataTable dtSchema;
                dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string nomePlanilha = dtSchema.Rows[0]["TABLE_NAME"].ToString();
                conn.Close();
                //le todos os dados da planilha para o Data Table    
                conn.Open();
                cmd.CommandText = "SELECT * From [" + nomePlanilha + "]";
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dt);
                conn.Close();
                //DataTable dt = new DataTable();

                //converte os dados do Excel para um DataTable
                this.BeginInvoke((MethodInvoker)delegate
                {
                    dgvDadosExcel.DataSource = dt;
                    //DataTable dt = GetTabelaExcel(arquivoExcel);
                    //ajusta a largura das colunas aos dados
                    //No total de registros
                    lblRegistros.Text = (dgvDadosExcel.Rows.Count - 1).ToString();
                    string[] listaNomeColunas = dt.Columns.OfType<DataColumn>().Select(x => x.ColumnName).ToArray();
                });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Maximized)
            //{
            //    dgvDadosExcel.Size = new Size(Width - 35, 235);
            //    dgvDadosExcel.Location = new Point(12, 550);
            //}
            //else
            //{
            //    dgvDadosExcel.Size = new Size(1324, 288);
            //    dgvDadosExcel.Location = new Point(12, 436);
            //}
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, new FileStream(@"C:\Users\Diego\Desktop\TestPdf.pdf", FileMode.Create));
            document.Open();
            BaseFont bfTimes = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
            iTextSharp.text.Font times = new iTextSharp.text.Font(bfTimes, 12, iTextSharp.text.Font.NORMAL, BaseColor.RED);
            document.Add(new Paragraph(String.Format("Confidencial {0}", DateTime.Now.ToString()))
            {
                Alignment = 1,
            });
            Paragraph p = new Paragraph("ESTUDO DE MERCADO / BENEFÍCIOS", times);
            p.Alignment = 1;
            document.Add(p);
            document.Close();
            //System.Drawing.Image ImagemPdf = System.Drawing.Image.GetInstance(stream);
            //document.Add(ImagemPdf);
        }

        private void dataGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDataGrid dg = new frmDataGrid();
            dg.ShowDialog();
        }
    }
}
