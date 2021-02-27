
namespace GeradorDePropostas
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gerarTabulaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subscriçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarPropostaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresarialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subscriçãoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gerarPropostaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvDadosExcel = new System.Windows.Forms.DataGridView();
            this.tbArquivoExcel = new System.Windows.Forms.TextBox();
            this.ofdLocalizaExcel = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.tbConsideracoes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCoparticipacao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFormaContratacao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSinistralidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosExcel)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gerarTabulaçãoToolStripMenuItem,
            this.dataGridToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1348, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gerarTabulaçãoToolStripMenuItem
            // 
            this.gerarTabulaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pMEToolStripMenuItem,
            this.empresarialToolStripMenuItem});
            this.gerarTabulaçãoToolStripMenuItem.Name = "gerarTabulaçãoToolStripMenuItem";
            this.gerarTabulaçãoToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.gerarTabulaçãoToolStripMenuItem.Text = "&Gerar Tabulação";
            // 
            // pMEToolStripMenuItem
            // 
            this.pMEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subscriçãoToolStripMenuItem,
            this.gerarPropostaToolStripMenuItem});
            this.pMEToolStripMenuItem.Name = "pMEToolStripMenuItem";
            this.pMEToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.pMEToolStripMenuItem.Text = "PME";
            // 
            // subscriçãoToolStripMenuItem
            // 
            this.subscriçãoToolStripMenuItem.Name = "subscriçãoToolStripMenuItem";
            this.subscriçãoToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.subscriçãoToolStripMenuItem.Text = "Subscrição";
            // 
            // gerarPropostaToolStripMenuItem
            // 
            this.gerarPropostaToolStripMenuItem.Name = "gerarPropostaToolStripMenuItem";
            this.gerarPropostaToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.gerarPropostaToolStripMenuItem.Text = "Gerar proposta";
            // 
            // empresarialToolStripMenuItem
            // 
            this.empresarialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subscriçãoToolStripMenuItem1,
            this.gerarPropostaToolStripMenuItem1});
            this.empresarialToolStripMenuItem.Name = "empresarialToolStripMenuItem";
            this.empresarialToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.empresarialToolStripMenuItem.Text = "Empresarial";
            // 
            // subscriçãoToolStripMenuItem1
            // 
            this.subscriçãoToolStripMenuItem1.Name = "subscriçãoToolStripMenuItem1";
            this.subscriçãoToolStripMenuItem1.Size = new System.Drawing.Size(192, 26);
            this.subscriçãoToolStripMenuItem1.Text = "Subscrição";
            // 
            // gerarPropostaToolStripMenuItem1
            // 
            this.gerarPropostaToolStripMenuItem1.Name = "gerarPropostaToolStripMenuItem1";
            this.gerarPropostaToolStripMenuItem1.Size = new System.Drawing.Size(192, 26);
            this.gerarPropostaToolStripMenuItem1.Text = "Gerar proposta";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(940, 170);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(129, 35);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar Arquivo...";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvDadosExcel
            // 
            this.dgvDadosExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDadosExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosExcel.Location = new System.Drawing.Point(12, 436);
            this.dgvDadosExcel.Name = "dgvDadosExcel";
            this.dgvDadosExcel.RowHeadersWidth = 51;
            this.dgvDadosExcel.RowTemplate.Height = 24;
            this.dgvDadosExcel.Size = new System.Drawing.Size(1324, 288);
            this.dgvDadosExcel.TabIndex = 3;
            // 
            // tbArquivoExcel
            // 
            this.tbArquivoExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbArquivoExcel.Location = new System.Drawing.Point(174, 172);
            this.tbArquivoExcel.Name = "tbArquivoExcel";
            this.tbArquivoExcel.Size = new System.Drawing.Size(755, 30);
            this.tbArquivoExcel.TabIndex = 4;
            // 
            // ofdLocalizaExcel
            // 
            this.ofdLocalizaExcel.FileName = "ofdLocalizaExcel";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblRegistros});
            this.statusStrip1.Location = new System.Drawing.Point(0, 727);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1348, 26);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(127, 20);
            this.toolStripStatusLabel1.Text = "Total de registros:";
            // 
            // lblRegistros
            // 
            this.lblRegistros.Name = "lblRegistros";
            this.lblRegistros.Size = new System.Drawing.Size(66, 20);
            this.lblRegistros.Text = "registros";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ButtonSave);
            this.groupBox1.Controls.Add(this.tbConsideracoes);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbCoparticipacao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbArquivoExcel);
            this.groupBox1.Controls.Add(this.tbFormaContratacao);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbSinistralidade);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1324, 382);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Subscrição de Riscos";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(1075, 170);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(129, 35);
            this.ButtonSave.TabIndex = 11;
            this.ButtonSave.Text = "PDF";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // tbConsideracoes
            // 
            this.tbConsideracoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbConsideracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConsideracoes.Location = new System.Drawing.Point(13, 245);
            this.tbConsideracoes.Multiline = true;
            this.tbConsideracoes.Name = "tbConsideracoes";
            this.tbConsideracoes.Size = new System.Drawing.Size(1305, 127);
            this.tbConsideracoes.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Considerações Finais:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Import. Arquivo:";
            // 
            // tbCoparticipacao
            // 
            this.tbCoparticipacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCoparticipacao.Location = new System.Drawing.Point(163, 125);
            this.tbCoparticipacao.Name = "tbCoparticipacao";
            this.tbCoparticipacao.Size = new System.Drawing.Size(265, 30);
            this.tbCoparticipacao.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "CoParticipação:";
            // 
            // tbFormaContratacao
            // 
            this.tbFormaContratacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFormaContratacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFormaContratacao.Location = new System.Drawing.Point(705, 80);
            this.tbFormaContratacao.Name = "tbFormaContratacao";
            this.tbFormaContratacao.Size = new System.Drawing.Size(613, 30);
            this.tbFormaContratacao.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Forma de Contratação*:";
            // 
            // tbSinistralidade
            // 
            this.tbSinistralidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSinistralidade.Location = new System.Drawing.Point(184, 80);
            this.tbSinistralidade.Name = "tbSinistralidade";
            this.tbSinistralidade.Size = new System.Drawing.Size(244, 30);
            this.tbSinistralidade.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sinistralidade (%):";
            // 
            // tbCliente
            // 
            this.tbCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCliente.Location = new System.Drawing.Point(99, 36);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(1219, 30);
            this.tbCliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente*:";
            // 
            // dataGridToolStripMenuItem
            // 
            this.dataGridToolStripMenuItem.Name = "dataGridToolStripMenuItem";
            this.dataGridToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.dataGridToolStripMenuItem.Text = "DataGrid";
            this.dataGridToolStripMenuItem.Click += new System.EventHandler(this.dataGridToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 753);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvDadosExcel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de propostas e subscrição";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosExcel)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gerarTabulaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subscriçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gerarPropostaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresarialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subscriçãoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gerarPropostaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvDadosExcel;
        private System.Windows.Forms.TextBox tbArquivoExcel;
        private System.Windows.Forms.OpenFileDialog ofdLocalizaExcel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblRegistros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbConsideracoes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCoparticipacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFormaContratacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSinistralidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.ToolStripMenuItem dataGridToolStripMenuItem;
    }
}

