namespace CadastroMedicamento
{
    partial class Pesquisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pesquisar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.mktxtQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.txtPrincipioAtivo = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblPrincipioAtivo = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtNomeMedicamento = new System.Windows.Forms.TextBox();
            this.lblNomeMedicamento = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtContador = new System.Windows.Forms.TextBox();
            this.lblFimRegistro = new System.Windows.Forms.Label();
            this.lblPagina = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Anterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.dgPesquisa = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rblTudo = new System.Windows.Forms.RadioButton();
            this.rblQuantidade = new System.Windows.Forms.RadioButton();
            this.rblPrincipioAtivo = new System.Windows.Forms.RadioButton();
            this.rblNomeFantasia = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgProdutoDataVencendo = new System.Windows.Forms.DataGridView();
            this.NomeMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrincipioAtivo2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apresentacao2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClasseTerapeuticaVencido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DosagemVencido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fabricante2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataValidade2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataFabricacao2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoBarras2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisa)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutoDataVencendo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.mktxtQuantidade);
            this.groupBox1.Controls.Add(this.txtPrincipioAtivo);
            this.groupBox1.Controls.Add(this.lblQuantidade);
            this.groupBox1.Controls.Add(this.lblPrincipioAtivo);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.txtNomeMedicamento);
            this.groupBox1.Controls.Add(this.lblNomeMedicamento);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(164, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(541, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 49);
            this.button1.TabIndex = 8;
            this.button1.Text = "Pesquisar Vencidos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(644, 29);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 36);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // mktxtQuantidade
            // 
            this.mktxtQuantidade.Location = new System.Drawing.Point(145, 72);
            this.mktxtQuantidade.Mask = "000";
            this.mktxtQuantidade.Name = "mktxtQuantidade";
            this.mktxtQuantidade.Size = new System.Drawing.Size(34, 21);
            this.mktxtQuantidade.TabIndex = 6;
            // 
            // txtPrincipioAtivo
            // 
            this.txtPrincipioAtivo.Location = new System.Drawing.Point(145, 42);
            this.txtPrincipioAtivo.Name = "txtPrincipioAtivo";
            this.txtPrincipioAtivo.Size = new System.Drawing.Size(213, 21);
            this.txtPrincipioAtivo.TabIndex = 5;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(23, 75);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(71, 15);
            this.lblQuantidade.TabIndex = 4;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // lblPrincipioAtivo
            // 
            this.lblPrincipioAtivo.AutoSize = true;
            this.lblPrincipioAtivo.Location = new System.Drawing.Point(23, 46);
            this.lblPrincipioAtivo.Name = "lblPrincipioAtivo";
            this.lblPrincipioAtivo.Size = new System.Drawing.Size(83, 15);
            this.lblPrincipioAtivo.TabIndex = 3;
            this.lblPrincipioAtivo.Text = "Principio Ativo";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(433, 29);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 36);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtNomeMedicamento
            // 
            this.txtNomeMedicamento.BackColor = System.Drawing.SystemColors.Window;
            this.txtNomeMedicamento.Location = new System.Drawing.Point(145, 16);
            this.txtNomeMedicamento.Name = "txtNomeMedicamento";
            this.txtNomeMedicamento.Size = new System.Drawing.Size(213, 21);
            this.txtNomeMedicamento.TabIndex = 1;
            // 
            // lblNomeMedicamento
            // 
            this.lblNomeMedicamento.AutoSize = true;
            this.lblNomeMedicamento.Location = new System.Drawing.Point(6, 22);
            this.lblNomeMedicamento.Name = "lblNomeMedicamento";
            this.lblNomeMedicamento.Size = new System.Drawing.Size(137, 15);
            this.lblNomeMedicamento.TabIndex = 0;
            this.lblNomeMedicamento.Text = "Nome do Medicamento";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox2.Controls.Add(this.txtContador);
            this.groupBox2.Controls.Add(this.lblFimRegistro);
            this.groupBox2.Controls.Add(this.lblPagina);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Anterior);
            this.groupBox2.Controls.Add(this.btnProximo);
            this.groupBox2.Controls.Add(this.dgPesquisa);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(12, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1010, 286);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado da Pesquisa";
            // 
            // txtContador
            // 
            this.txtContador.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContador.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtContador.Location = new System.Drawing.Point(448, 253);
            this.txtContador.Name = "txtContador";
            this.txtContador.ReadOnly = true;
            this.txtContador.Size = new System.Drawing.Size(23, 23);
            this.txtContador.TabIndex = 6;
            // 
            // lblFimRegistro
            // 
            this.lblFimRegistro.AutoSize = true;
            this.lblFimRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFimRegistro.ForeColor = System.Drawing.Color.DarkRed;
            this.lblFimRegistro.Location = new System.Drawing.Point(205, 177);
            this.lblFimRegistro.Name = "lblFimRegistro";
            this.lblFimRegistro.Size = new System.Drawing.Size(0, 20);
            this.lblFimRegistro.TabIndex = 5;
            // 
            // lblPagina
            // 
            this.lblPagina.AutoSize = true;
            this.lblPagina.Location = new System.Drawing.Point(383, 256);
            this.lblPagina.Name = "lblPagina";
            this.lblPagina.Size = new System.Drawing.Size(0, 17);
            this.lblPagina.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pagina:";
            // 
            // Anterior
            // 
            this.Anterior.Location = new System.Drawing.Point(286, 253);
            this.Anterior.Name = "Anterior";
            this.Anterior.Size = new System.Drawing.Size(75, 23);
            this.Anterior.TabIndex = 2;
            this.Anterior.Text = "Anterior";
            this.Anterior.UseVisualStyleBackColor = true;
            this.Anterior.Click += new System.EventHandler(this.Anterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(536, 254);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(75, 23);
            this.btnProximo.TabIndex = 1;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // dgPesquisa
            // 
            this.dgPesquisa.AllowUserToAddRows = false;
            this.dgPesquisa.AllowUserToDeleteRows = false;
            this.dgPesquisa.AllowUserToOrderColumns = true;
            this.dgPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPesquisa.Location = new System.Drawing.Point(9, 34);
            this.dgPesquisa.Name = "dgPesquisa";
            this.dgPesquisa.ReadOnly = true;
            this.dgPesquisa.Size = new System.Drawing.Size(989, 213);
            this.dgPesquisa.TabIndex = 0;
            this.dgPesquisa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPesquisa_CellContentClick);
            this.dgPesquisa.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgPesquisa_ColumnHeaderMouseClick);
            this.dgPesquisa.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgPesquisa_ColumnHeaderMouseDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox3.Controls.Add(this.rblTudo);
            this.groupBox3.Controls.Add(this.rblQuantidade);
            this.groupBox3.Controls.Add(this.rblPrincipioAtivo);
            this.groupBox3.Controls.Add(this.rblNomeFantasia);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(146, 127);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opções";
            // 
            // rblTudo
            // 
            this.rblTudo.AutoSize = true;
            this.rblTudo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rblTudo.Location = new System.Drawing.Point(9, 95);
            this.rblTudo.Name = "rblTudo";
            this.rblTudo.Size = new System.Drawing.Size(53, 19);
            this.rblTudo.TabIndex = 3;
            this.rblTudo.TabStop = true;
            this.rblTudo.Text = "Tudo";
            this.rblTudo.UseVisualStyleBackColor = true;
            this.rblTudo.MouseCaptureChanged += new System.EventHandler(this.rblTudo_MouseCaptureChanged);
            // 
            // rblQuantidade
            // 
            this.rblQuantidade.AutoSize = true;
            this.rblQuantidade.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rblQuantidade.Location = new System.Drawing.Point(9, 70);
            this.rblQuantidade.Name = "rblQuantidade";
            this.rblQuantidade.Size = new System.Drawing.Size(89, 19);
            this.rblQuantidade.TabIndex = 2;
            this.rblQuantidade.TabStop = true;
            this.rblQuantidade.Text = "Quantidade";
            this.rblQuantidade.UseVisualStyleBackColor = true;
            this.rblQuantidade.MouseCaptureChanged += new System.EventHandler(this.rbQuantidade_MouseCaptureChanged);
            // 
            // rblPrincipioAtivo
            // 
            this.rblPrincipioAtivo.AutoSize = true;
            this.rblPrincipioAtivo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rblPrincipioAtivo.Location = new System.Drawing.Point(9, 46);
            this.rblPrincipioAtivo.Name = "rblPrincipioAtivo";
            this.rblPrincipioAtivo.Size = new System.Drawing.Size(101, 19);
            this.rblPrincipioAtivo.TabIndex = 1;
            this.rblPrincipioAtivo.TabStop = true;
            this.rblPrincipioAtivo.Text = "Principio Ativo";
            this.rblPrincipioAtivo.UseVisualStyleBackColor = true;
            this.rblPrincipioAtivo.MouseCaptureChanged += new System.EventHandler(this.rbPrincipio_MouseCaptureChanged);
            // 
            // rblNomeFantasia
            // 
            this.rblNomeFantasia.AutoSize = true;
            this.rblNomeFantasia.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.rblNomeFantasia.Location = new System.Drawing.Point(9, 22);
            this.rblNomeFantasia.Name = "rblNomeFantasia";
            this.rblNomeFantasia.Size = new System.Drawing.Size(109, 19);
            this.rblNomeFantasia.TabIndex = 0;
            this.rblNomeFantasia.TabStop = true;
            this.rblNomeFantasia.Text = "Nome Fantasia";
            this.rblNomeFantasia.UseVisualStyleBackColor = true;
            this.rblNomeFantasia.MouseCaptureChanged += new System.EventHandler(this.rbNome_MouseCaptureChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox4.Controls.Add(this.dgProdutoDataVencendo);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox4.Location = new System.Drawing.Point(12, 437);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1010, 181);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Produtos com Datas Perto do Vencimento";
            // 
            // dgProdutoDataVencendo
            // 
            this.dgProdutoDataVencendo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProdutoDataVencendo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeMedicamento,
            this.PrincipioAtivo2,
            this.Apresentacao2,
            this.ClasseTerapeuticaVencido,
            this.DosagemVencido,
            this.Fabricante2,
            this.DataValidade2,
            this.DataFabricacao2,
            this.Quantidade2,
            this.CodigoBarras2});
            this.dgProdutoDataVencendo.Location = new System.Drawing.Point(9, 23);
            this.dgProdutoDataVencendo.Name = "dgProdutoDataVencendo";
            this.dgProdutoDataVencendo.Size = new System.Drawing.Size(989, 138);
            this.dgProdutoDataVencendo.TabIndex = 0;
            // 
            // NomeMedicamento
            // 
            this.NomeMedicamento.DataPropertyName = "nome";
            this.NomeMedicamento.HeaderText = "Nome do Medicamento";
            this.NomeMedicamento.Name = "NomeMedicamento";
            this.NomeMedicamento.ReadOnly = true;
            this.NomeMedicamento.Width = 170;
            // 
            // PrincipioAtivo2
            // 
            this.PrincipioAtivo2.DataPropertyName = "principioAtivo";
            this.PrincipioAtivo2.HeaderText = "Principio Ativo";
            this.PrincipioAtivo2.Name = "PrincipioAtivo2";
            this.PrincipioAtivo2.ReadOnly = true;
            // 
            // Apresentacao2
            // 
            this.Apresentacao2.DataPropertyName = "apresentacao";
            this.Apresentacao2.HeaderText = "Forma Terapêutica";
            this.Apresentacao2.Name = "Apresentacao2";
            this.Apresentacao2.ReadOnly = true;
            // 
            // ClasseTerapeuticaVencido
            // 
            this.ClasseTerapeuticaVencido.DataPropertyName = "classeTerapeutica";
            this.ClasseTerapeuticaVencido.HeaderText = "Classe Terapêutica";
            this.ClasseTerapeuticaVencido.Name = "ClasseTerapeuticaVencido";
            // 
            // DosagemVencido
            // 
            this.DosagemVencido.DataPropertyName = "dosagem";
            this.DosagemVencido.HeaderText = "Dosagem";
            this.DosagemVencido.Name = "DosagemVencido";
            // 
            // Fabricante2
            // 
            this.Fabricante2.DataPropertyName = "fabricante";
            this.Fabricante2.HeaderText = "Fabricante";
            this.Fabricante2.Name = "Fabricante2";
            this.Fabricante2.ReadOnly = true;
            // 
            // DataValidade2
            // 
            this.DataValidade2.DataPropertyName = "dataValidade";
            this.DataValidade2.HeaderText = "Validade";
            this.DataValidade2.Name = "DataValidade2";
            this.DataValidade2.ReadOnly = true;
            // 
            // DataFabricacao2
            // 
            this.DataFabricacao2.DataPropertyName = "dataFabricacao";
            this.DataFabricacao2.HeaderText = "Fabricação";
            this.DataFabricacao2.Name = "DataFabricacao2";
            this.DataFabricacao2.ReadOnly = true;
            // 
            // Quantidade2
            // 
            this.Quantidade2.DataPropertyName = "quantidade";
            this.Quantidade2.HeaderText = "Qtd";
            this.Quantidade2.Name = "Quantidade2";
            this.Quantidade2.ReadOnly = true;
            this.Quantidade2.Width = 60;
            // 
            // CodigoBarras2
            // 
            this.CodigoBarras2.DataPropertyName = "codigoBarras";
            this.CodigoBarras2.HeaderText = "Código";
            this.CodigoBarras2.Name = "CodigoBarras2";
            this.CodigoBarras2.ReadOnly = true;
            this.CodigoBarras2.Width = 160;
            // 
            // Pesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 630);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pesquisar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar";
            this.Load += new System.EventHandler(this.Pesquisar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisa)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgProdutoDataVencendo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNomeMedicamento;
        private System.Windows.Forms.Label lblNomeMedicamento;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rblPrincipioAtivo;
        private System.Windows.Forms.RadioButton rblNomeFantasia;
        private System.Windows.Forms.RadioButton rblQuantidade;
        private System.Windows.Forms.DataGridView dgPesquisa;
        private System.Windows.Forms.TextBox txtPrincipioAtivo;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblPrincipioAtivo;
        private System.Windows.Forms.MaskedTextBox mktxtQuantidade;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView dgProdutoDataVencendo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button Anterior;
        private System.Windows.Forms.Label lblPagina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFimRegistro;
        private System.Windows.Forms.RadioButton rblTudo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrincipioAtivo2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apresentacao2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClasseTerapeuticaVencido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DosagemVencido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fabricante2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataValidade2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataFabricacao2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBarras2;
        private System.Windows.Forms.TextBox txtContador;
    }
}