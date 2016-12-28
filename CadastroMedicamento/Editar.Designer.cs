namespace CadastroMedicamento
{
    partial class Editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbClasseTerapeutica = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mkEstoqueMinimo = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDosagem = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.dtpValidade = new System.Windows.Forms.DateTimePicker();
            this.dtpFabricacao = new System.Windows.Forms.DateTimePicker();
            this.mktCodigoBarras = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtApresentacao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrincipioAtivo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFabricante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.cbClasseTerapeutica);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.mkEstoqueMinimo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbDosagem);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtQuantidade);
            this.groupBox1.Controls.Add(this.dtpValidade);
            this.groupBox1.Controls.Add(this.dtpFabricacao);
            this.groupBox1.Controls.Add(this.mktCodigoBarras);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.txtApresentacao);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnAlterar);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPrincipioAtivo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtFabricante);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 508);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manutenção das Informações";
            // 
            // cbClasseTerapeutica
            // 
            this.cbClasseTerapeutica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClasseTerapeutica.FormattingEnabled = true;
            this.cbClasseTerapeutica.Items.AddRange(new object[] {
            "Anti-helminitico",
            "Anti-Infecciosos Sistêmicos",
            "Anti-Parasitários",
            "Aparelhos Geniturinário",
            "Anti-Protozoários",
            "Anti-Inflamatório",
            "Aparelho Cardiovascular",
            "Aparelho Locomotor",
            "Anti-Emetico",
            "AntiNeoplasico",
            "Aparelho Digestivo",
            "Aparelho Respiratório",
            "Modificadores do Metabolismo",
            "Não Identificada",
            "Pele e Mucosas",
            "Sangue Líquido e Eletrólitos",
            "Oftamológicos",
            "Sistema Nervoso",
            "\t"});
            this.cbClasseTerapeutica.Location = new System.Drawing.Point(26, 414);
            this.cbClasseTerapeutica.Name = "cbClasseTerapeutica";
            this.cbClasseTerapeutica.Size = new System.Drawing.Size(210, 24);
            this.cbClasseTerapeutica.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 17);
            this.label10.TabIndex = 46;
            this.label10.Text = "Classe Terapêutica";
            // 
            // mkEstoqueMinimo
            // 
            this.mkEstoqueMinimo.Location = new System.Drawing.Point(555, 201);
            this.mkEstoqueMinimo.Mask = "0000";
            this.mkEstoqueMinimo.Name = "mkEstoqueMinimo";
            this.mkEstoqueMinimo.Size = new System.Drawing.Size(30, 23);
            this.mkEstoqueMinimo.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Estoque Mínimo";
            // 
            // cbDosagem
            // 
            this.cbDosagem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDosagem.FormattingEnabled = true;
            this.cbDosagem.Items.AddRange(new object[] {
            "Selecione",
            "500 mg",
            "250 mg"});
            this.cbDosagem.Location = new System.Drawing.Point(410, 128);
            this.cbDosagem.Name = "cbDosagem";
            this.cbDosagem.Size = new System.Drawing.Size(210, 24);
            this.cbDosagem.TabIndex = 43;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(407, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 42;
            this.label12.Text = "Dosagem";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(410, 203);
            this.txtQuantidade.Mask = "000";
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(34, 23);
            this.txtQuantidade.TabIndex = 41;
            // 
            // dtpValidade
            // 
            this.dtpValidade.CustomFormat = "MM/yyyy";
            this.dtpValidade.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpValidade.Location = new System.Drawing.Point(410, 345);
            this.dtpValidade.Name = "dtpValidade";
            this.dtpValidade.Size = new System.Drawing.Size(79, 23);
            this.dtpValidade.TabIndex = 40;
            // 
            // dtpFabricacao
            // 
            this.dtpFabricacao.CustomFormat = "MM/yyyy";
            this.dtpFabricacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFabricacao.Location = new System.Drawing.Point(410, 268);
            this.dtpFabricacao.Name = "dtpFabricacao";
            this.dtpFabricacao.Size = new System.Drawing.Size(79, 23);
            this.dtpFabricacao.TabIndex = 39;
            // 
            // mktCodigoBarras
            // 
            this.mktCodigoBarras.Location = new System.Drawing.Point(26, 65);
            this.mktCodigoBarras.Mask = "0000000000000";
            this.mktCodigoBarras.Name = "mktCodigoBarras";
            this.mktCodigoBarras.Size = new System.Drawing.Size(105, 23);
            this.mktCodigoBarras.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "Código";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(571, 456);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 30);
            this.btnSair.TabIndex = 37;
            this.btnSair.Text = "Voltar";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(465, 456);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 30);
            this.btnLimpar.TabIndex = 36;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtApresentacao
            // 
            this.txtApresentacao.Location = new System.Drawing.Point(26, 343);
            this.txtApresentacao.Name = "txtApresentacao";
            this.txtApresentacao.Size = new System.Drawing.Size(354, 23);
            this.txtApresentacao.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Forma Farmacêutica";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = global::CadastroMedicamento.Properties.Resources._6228_16x16;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(350, 456);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 30);
            this.btnAlterar.TabIndex = 33;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Data de Validade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Data de Fabricação";
            // 
            // txtPrincipioAtivo
            // 
            this.txtPrincipioAtivo.Location = new System.Drawing.Point(26, 201);
            this.txtPrincipioAtivo.Name = "txtPrincipioAtivo";
            this.txtPrincipioAtivo.Size = new System.Drawing.Size(354, 23);
            this.txtPrincipioAtivo.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Principio Ativo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Quantidade";
            // 
            // txtFabricante
            // 
            this.txtFabricante.Location = new System.Drawing.Point(26, 268);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(354, 23);
            this.txtFabricante.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fabricante";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(26, 128);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(354, 23);
            this.txtNome.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome Fantasia";
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 532);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Editar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox mktCodigoBarras;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtApresentacao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrincipioAtivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpValidade;
        private System.Windows.Forms.DateTimePicker dtpFabricacao;
        private System.Windows.Forms.MaskedTextBox txtQuantidade;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbDosagem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mkEstoqueMinimo;
        private System.Windows.Forms.ComboBox cbClasseTerapeutica;
        private System.Windows.Forms.Label label10;
    }
}