namespace CadastroMedicamento
{
    partial class TelaCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaCadastro));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDosagem = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbClasseTerapeutica = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.mkEstoqueMinimo = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.dtpValidacao = new System.Windows.Forms.DateTimePicker();
            this.dtpFabricacao = new System.Windows.Forms.DateTimePicker();
            this.txtCodigoBarras = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtFormaFarmaceutica = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
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
            this.groupBox1.Controls.Add(this.cbDosagem);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbClasseTerapeutica);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.mkEstoqueMinimo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtQuantidade);
            this.groupBox1.Controls.Add(this.dtpValidacao);
            this.groupBox1.Controls.Add(this.dtpFabricacao);
            this.groupBox1.Controls.Add(this.txtCodigoBarras);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.txtFormaFarmaceutica);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnGravar);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(677, 508);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medicamentos";
            // 
            // cbDosagem
            // 
            this.cbDosagem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDosagem.FormattingEnabled = true;
            this.cbDosagem.Items.AddRange(new object[] {
            "Selecione",
            "500 mg",
            "250 mg"});
            this.cbDosagem.Location = new System.Drawing.Point(426, 121);
            this.cbDosagem.Name = "cbDosagem";
            this.cbDosagem.Size = new System.Drawing.Size(210, 24);
            this.cbDosagem.TabIndex = 30;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(423, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "Dosagem";
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
            this.cbClasseTerapeutica.Location = new System.Drawing.Point(21, 406);
            this.cbClasseTerapeutica.Name = "cbClasseTerapeutica";
            this.cbClasseTerapeutica.Size = new System.Drawing.Size(210, 24);
            this.cbClasseTerapeutica.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Classe Terapêutica";
            // 
            // mkEstoqueMinimo
            // 
            this.mkEstoqueMinimo.Location = new System.Drawing.Point(541, 193);
            this.mkEstoqueMinimo.Mask = "0000";
            this.mkEstoqueMinimo.Name = "mkEstoqueMinimo";
            this.mkEstoqueMinimo.Size = new System.Drawing.Size(30, 23);
            this.mkEstoqueMinimo.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Estoque Mínimo";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(424, 193);
            this.txtQuantidade.Mask = "0000";
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(30, 23);
            this.txtQuantidade.TabIndex = 22;
            // 
            // dtpValidacao
            // 
            this.dtpValidacao.CustomFormat = "MM/yyyy";
            this.dtpValidacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpValidacao.Location = new System.Drawing.Point(426, 335);
            this.dtpValidacao.Name = "dtpValidacao";
            this.dtpValidacao.Size = new System.Drawing.Size(79, 23);
            this.dtpValidacao.TabIndex = 21;
            // 
            // dtpFabricacao
            // 
            this.dtpFabricacao.CustomFormat = "MM/yyyy";
            this.dtpFabricacao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFabricacao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpFabricacao.Location = new System.Drawing.Point(426, 263);
            this.dtpFabricacao.Name = "dtpFabricacao";
            this.dtpFabricacao.Size = new System.Drawing.Size(79, 23);
            this.dtpFabricacao.TabIndex = 20;
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Location = new System.Drawing.Point(24, 58);
            this.txtCodigoBarras.Mask = "0000000000000";
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(105, 23);
            this.txtCodigoBarras.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Código";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(571, 471);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 30);
            this.btnSair.TabIndex = 17;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(465, 471);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 30);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtFormaFarmaceutica
            // 
            this.txtFormaFarmaceutica.Location = new System.Drawing.Point(21, 335);
            this.txtFormaFarmaceutica.Name = "txtFormaFarmaceutica";
            this.txtFormaFarmaceutica.Size = new System.Drawing.Size(354, 23);
            this.txtFormaFarmaceutica.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Forma Farmaceutica";
            // 
            // btnGravar
            // 
            this.btnGravar.Image = global::CadastroMedicamento.Properties.Resources._6228_16x16;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.Location = new System.Drawing.Point(350, 471);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 30);
            this.btnGravar.TabIndex = 10;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(423, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Data de Validade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Data de Fabricação";
            // 
            // txtPrincipioAtivo
            // 
            this.txtPrincipioAtivo.Location = new System.Drawing.Point(21, 193);
            this.txtPrincipioAtivo.Name = "txtPrincipioAtivo";
            this.txtPrincipioAtivo.Size = new System.Drawing.Size(354, 23);
            this.txtPrincipioAtivo.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Principio Ativo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantidade";
            // 
            // txtFabricante
            // 
            this.txtFabricante.Location = new System.Drawing.Point(21, 260);
            this.txtFabricante.Name = "txtFabricante";
            this.txtFabricante.Size = new System.Drawing.Size(354, 23);
            this.txtFabricante.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fabricante";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(21, 120);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(354, 23);
            this.txtNome.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Fantasia";
            // 
            // TelaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 532);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaCadastro";
            this.Load += new System.EventHandler(this.TelaCadastro_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFabricante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrincipioAtivo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFormaFarmaceutica;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtCodigoBarras;
        private System.Windows.Forms.DateTimePicker dtpFabricacao;
        private System.Windows.Forms.DateTimePicker dtpValidacao;
        private System.Windows.Forms.MaskedTextBox txtQuantidade;
        private System.Windows.Forms.ComboBox cbClasseTerapeutica;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox mkEstoqueMinimo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDosagem;
        private System.Windows.Forms.Label label12;
    }
}