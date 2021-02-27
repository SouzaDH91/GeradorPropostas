using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GeradorDePropostas
{
    public partial class frmDataGrid : Form
    {
        private DataGridView geradorDataGridView = new DataGridView();

        public frmDataGrid()
        {
            InitializeComponent();
        }

        private void frmDataGrid_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
            PopulateDataGridView();
        }

        private void SetupDataGridView()
        {
            this.Controls.Add(geradorDataGridView);

            geradorDataGridView.ColumnCount = 4;

            geradorDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            geradorDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            geradorDataGridView.ColumnHeadersDefaultCellStyle.Font =
                new Font(geradorDataGridView.Font, FontStyle.Bold);

            geradorDataGridView.Name = "geradorDataGridView";
            geradorDataGridView.Location = new Point(8, 8);
            geradorDataGridView.Size = new Size(500, 250);
            geradorDataGridView.AutoSizeRowsMode =
                DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            geradorDataGridView.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.Single;
            geradorDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            geradorDataGridView.GridColor = Color.Black;
            geradorDataGridView.RowHeadersVisible = false;

            geradorDataGridView.Columns[0].Name = "Faixa Etária";
            geradorDataGridView.Columns[1].Name = "Vida";
            geradorDataGridView.Columns[2].Name = "Custo Un.";
            geradorDataGridView.Columns[3].Name = "Total";
            //geradorDataGridView.Columns[4].DefaultCellStyle.Font =
            //    new Font(geradorDataGridView.DefaultCellStyle.Font, FontStyle.Italic);

            geradorDataGridView.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            geradorDataGridView.MultiSelect = false;
            geradorDataGridView.Dock = DockStyle.Fill;

            /*geradorDataGridView.CellFormatting += new
                DataGridViewCellFormattingEventHandler(
                geradorDataGridView_CellFormatting);*/
        }
        private void PopulateDataGridView()
        {

            string[] row0 = { "0 a 18", "28", "333,72",
            "9344,16" };
            string[] row1 = { "19 a 23", "6", "333,72",
            "2002,32" };
            string[] row2 = { "24 a 28", "15", "333,72",
            "5005,8" };
            string[] row3 = { "29 a 33", "52", "333,72",
            "9344,16" };
            string[] row4 = { "34 a 38", "13", "333,72",
            "4338,36" };
            string[] row5 = { "39 a 43", "12", "333,72",
            "4004,64" };
            string[] row6 = { "44 a 48", "6", "333,72",
            "2002,32" };
            string[] row7 = { "49 a 53", "2", "333,72",
            "667,44" };
            string[] row8 = { "54 a 58", "2", "333,72",
            "667,44" };
            string[] row9 = { "59 ou mais", "1", "333,72",
            "333,72" };

            geradorDataGridView.Rows.Add(row0);
            geradorDataGridView.Rows.Add(row1);
            geradorDataGridView.Rows.Add(row2);
            geradorDataGridView.Rows.Add(row3);
            geradorDataGridView.Rows.Add(row4);
            geradorDataGridView.Rows.Add(row5);
            geradorDataGridView.Rows.Add(row6);
            geradorDataGridView.Rows.Add(row7);
            geradorDataGridView.Rows.Add(row8);
            geradorDataGridView.Rows.Add(row9);

            geradorDataGridView.Columns[0].DisplayIndex = 0;
            geradorDataGridView.Columns[1].DisplayIndex = 1;
            geradorDataGridView.Columns[2].DisplayIndex = 2;
            geradorDataGridView.Columns[3].DisplayIndex = 3;
            //geradorDataGridView.Columns[4].DisplayIndex = 4;
        }

    }
}
