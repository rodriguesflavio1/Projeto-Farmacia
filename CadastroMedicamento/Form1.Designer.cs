namespace CadastroMedicamento
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saídaDeMedicamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusPerfil = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblRelogio = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.relatórioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatórioPorDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(268, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Controle de Estoque da Farmacia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::CadastroMedicamento.Properties.Resources.logo_nosso_lar;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(915, 436);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.pesquisaToolStripMenuItem,
            this.controleToolStripMenuItem,
            this.relatórioToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(915, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeProdutosToolStripMenuItem,
            this.cadastroDeUsuáriosToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(66, 20);
            this.toolStripMenuItem1.Text = "Cadastro";
            // 
            // cadastroDeProdutosToolStripMenuItem
            // 
            this.cadastroDeProdutosToolStripMenuItem.Name = "cadastroDeProdutosToolStripMenuItem";
            this.cadastroDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cadastroDeProdutosToolStripMenuItem.Text = "Cadastro de Produtos";
            this.cadastroDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeProdutosToolStripMenuItem_Click);
            // 
            // cadastroDeUsuáriosToolStripMenuItem
            // 
            this.cadastroDeUsuáriosToolStripMenuItem.Name = "cadastroDeUsuáriosToolStripMenuItem";
            this.cadastroDeUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cadastroDeUsuáriosToolStripMenuItem.Text = "Cadastro de Usuários";
            this.cadastroDeUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeUsuáriosToolStripMenuItem_Click);
            // 
            // pesquisaToolStripMenuItem
            // 
            this.pesquisaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesquisarProdutoToolStripMenuItem});
            this.pesquisaToolStripMenuItem.Name = "pesquisaToolStripMenuItem";
            this.pesquisaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.pesquisaToolStripMenuItem.Text = "Pesquisa";
            // 
            // pesquisarProdutoToolStripMenuItem
            // 
            this.pesquisarProdutoToolStripMenuItem.Name = "pesquisarProdutoToolStripMenuItem";
            this.pesquisarProdutoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.pesquisarProdutoToolStripMenuItem.Text = "Pesquisar Produto";
            this.pesquisarProdutoToolStripMenuItem.Click += new System.EventHandler(this.pesquisarProdutoToolStripMenuItem_Click);
            // 
            // controleToolStripMenuItem
            // 
            this.controleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saídaDeMedicamentoToolStripMenuItem});
            this.controleToolStripMenuItem.Name = "controleToolStripMenuItem";
            this.controleToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.controleToolStripMenuItem.Text = "Controle";
            // 
            // saídaDeMedicamentoToolStripMenuItem
            // 
            this.saídaDeMedicamentoToolStripMenuItem.Name = "saídaDeMedicamentoToolStripMenuItem";
            this.saídaDeMedicamentoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.saídaDeMedicamentoToolStripMenuItem.Text = "Saída de Medicamento";
            this.saídaDeMedicamentoToolStripMenuItem.Click += new System.EventHandler(this.saídaDeMedicamentoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(108, 2);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(17, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusUsuario
            // 
            this.toolStripStatusUsuario.Name = "toolStripStatusUsuario";
            this.toolStripStatusUsuario.Size = new System.Drawing.Size(0, 17);
            this.toolStripStatusUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 222F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 187F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblRelogio, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblData, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 434);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(914, 26);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(335, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Perfil:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Usuário:";
            // 
            // statusStrip2
            // 
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusPerfil});
            this.statusStrip2.Location = new System.Drawing.Point(452, 2);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(182, 22);
            this.statusStrip2.TabIndex = 11;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusPerfil
            // 
            this.toolStripStatusPerfil.Name = "toolStripStatusPerfil";
            this.toolStripStatusPerfil.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblRelogio
            // 
            this.lblRelogio.AutoSize = true;
            this.lblRelogio.Location = new System.Drawing.Point(828, 2);
            this.lblRelogio.Name = "lblRelogio";
            this.lblRelogio.Size = new System.Drawing.Size(0, 15);
            this.lblRelogio.TabIndex = 12;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblData.Location = new System.Drawing.Point(639, 2);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(47, 15);
            this.lblData.TabIndex = 13;
            this.lblData.Text = "label4";
            // 
            // relatórioToolStripMenuItem
            // 
            this.relatórioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioPorDataToolStripMenuItem});
            this.relatórioToolStripMenuItem.Name = "relatórioToolStripMenuItem";
            this.relatórioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatórioToolStripMenuItem.Text = "Relatório";
            // 
            // relatórioPorDataToolStripMenuItem
            // 
            this.relatórioPorDataToolStripMenuItem.Name = "relatórioPorDataToolStripMenuItem";
            this.relatórioPorDataToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.relatórioPorDataToolStripMenuItem.Text = "Relatório Por Data";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 460);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Estoque Farmácia";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem cadastroDeProdutosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem cadastroDeUsuáriosToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem pesquisaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem pesquisarProdutoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem controleToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem saídaDeMedicamentoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusUsuario;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip2;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusPerfil;
        private System.Windows.Forms.Label lblRelogio;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ToolStripMenuItem relatórioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioPorDataToolStripMenuItem;
    }
}

