namespace CadastroMedicamento
{
    partial class Controle
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rblQuantidade = new System.Windows.Forms.RadioButton();
            this.rblPrincipioAtivo = new System.Windows.Forms.RadioButton();
            this.rblNomeFantasia = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.mktxtQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.txtPrincioAtivo = new System.Windows.Forms.TextBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblPrincipioAtivo = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtNomeMedicamento = new System.Windows.Forms.TextBox();
            this.lblNomeMedicamento = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFimRegistro = new System.Windows.Forms.Label();
            this.lblPagina = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Anterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.dgPesquisa = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRetirar = new System.Windows.Forms.Button();
            this.txtValidadeSaida = new System.Windows.Forms.TextBox();
            this.lblValidadeSaida = new System.Windows.Forms.Label();
            this.mktQuantidadeSaida = new System.Windows.Forms.MaskedTextBox();
            this.lblQuantidadeSaida = new System.Windows.Forms.Label();
            this.txtNomeSaida = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisa)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox3.Controls.Add(this.rblQuantidade);
            this.groupBox3.Controls.Add(this.rblPrincipioAtivo);
            this.groupBox3.Controls.Add(this.rblNomeFantasia);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(146, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opções";
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
            this.rblQuantidade.MouseCaptureChanged += new System.EventHandler(this.rblQuantidade_MouseCaptureChanged);
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
            this.rblPrincipioAtivo.MouseCaptureChanged += new System.EventHandler(this.rblPrincipioAtivo_MouseCaptureChanged);
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
            this.rblNomeFantasia.MouseCaptureChanged += new System.EventHandler(this.rblNomeFantasia_MouseCaptureChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.btnLimpar);
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.mktxtQuantidade);
            this.groupBox1.Controls.Add(this.txtPrincioAtivo);
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
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(532, 29);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 36);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(624, 29);
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
            // txtPrincioAtivo
            // 
            this.txtPrincioAtivo.Location = new System.Drawing.Point(145, 42);
            this.txtPrincioAtivo.Name = "txtPrincioAtivo";
            this.txtPrincioAtivo.Size = new System.Drawing.Size(213, 21);
            this.txtPrincioAtivo.TabIndex = 5;
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
            this.groupBox2.Controls.Add(this.lblFimRegistro);
            this.groupBox2.Controls.Add(this.lblPagina);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Anterior);
            this.groupBox2.Controls.Add(this.btnProximo);
            this.groupBox2.Controls.Add(this.dgPesquisa);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(926, 286);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado da Pesquisa";
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
            this.label1.Location = new System.Drawing.Point(320, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pagina:";
            // 
            // Anterior
            // 
            this.Anterior.Location = new System.Drawing.Point(220, 253);
            this.Anterior.Name = "Anterior";
            this.Anterior.Size = new System.Drawing.Size(75, 23);
            this.Anterior.TabIndex = 2;
            this.Anterior.Text = "Anterior";
            this.Anterior.UseVisualStyleBackColor = true;
            this.Anterior.Click += new System.EventHandler(this.Anterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(470, 254);
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
            this.dgPesquisa.Size = new System.Drawing.Size(862, 213);
            this.dgPesquisa.TabIndex = 0;
            this.dgPesquisa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPesquisa_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.btnRetirar);
            this.groupBox4.Controls.Add(this.txtValidadeSaida);
            this.groupBox4.Controls.Add(this.lblValidadeSaida);
            this.groupBox4.Controls.Add(this.mktQuantidadeSaida);
            this.groupBox4.Controls.Add(this.lblQuantidadeSaida);
            this.groupBox4.Controls.Add(this.txtNomeSaida);
            this.groupBox4.Controls.Add(this.lblnome);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox4.Location = new System.Drawing.Point(12, 433);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(670, 185);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Saída de Medicamentos";
            // 
            // btnRetirar
            // 
            this.btnRetirar.AutoSize = true;
            this.btnRetirar.Enabled = false;
            this.btnRetirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirar.Location = new System.Drawing.Point(429, 108);
            this.btnRetirar.Name = "btnRetirar";
            this.btnRetirar.Size = new System.Drawing.Size(85, 36);
            this.btnRetirar.TabIndex = 11;
            this.btnRetirar.Text = "RETIRAR";
            this.btnRetirar.UseVisualStyleBackColor = true;
            this.btnRetirar.Click += new System.EventHandler(this.btnRetirar_Click);
            // 
            // txtValidadeSaida
            // 
            this.txtValidadeSaida.Enabled = false;
            this.txtValidadeSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValidadeSaida.Location = new System.Drawing.Point(118, 79);
            this.txtValidadeSaida.Name = "txtValidadeSaida";
            this.txtValidadeSaida.Size = new System.Drawing.Size(82, 23);
            this.txtValidadeSaida.TabIndex = 10;
            // 
            // lblValidadeSaida
            // 
            this.lblValidadeSaida.AutoSize = true;
            this.lblValidadeSaida.Location = new System.Drawing.Point(6, 85);
            this.lblValidadeSaida.Name = "lblValidadeSaida";
            this.lblValidadeSaida.Size = new System.Drawing.Size(63, 17);
            this.lblValidadeSaida.TabIndex = 9;
            this.lblValidadeSaida.Text = "Validade";
            // 
            // mktQuantidadeSaida
            // 
            this.mktQuantidadeSaida.Enabled = false;
            this.mktQuantidadeSaida.Location = new System.Drawing.Point(470, 30);
            this.mktQuantidadeSaida.Mask = "000";
            this.mktQuantidadeSaida.Name = "mktQuantidadeSaida";
            this.mktQuantidadeSaida.Size = new System.Drawing.Size(34, 23);
            this.mktQuantidadeSaida.TabIndex = 8;
            // 
            // lblQuantidadeSaida
            // 
            this.lblQuantidadeSaida.AutoSize = true;
            this.lblQuantidadeSaida.Location = new System.Drawing.Point(369, 33);
            this.lblQuantidadeSaida.Name = "lblQuantidadeSaida";
            this.lblQuantidadeSaida.Size = new System.Drawing.Size(82, 17);
            this.lblQuantidadeSaida.TabIndex = 7;
            this.lblQuantidadeSaida.Text = "Quantidade";
            // 
            // txtNomeSaida
            // 
            this.txtNomeSaida.BackColor = System.Drawing.SystemColors.Window;
            this.txtNomeSaida.Enabled = false;
            this.txtNomeSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeSaida.Location = new System.Drawing.Point(118, 27);
            this.txtNomeSaida.Name = "txtNomeSaida";
            this.txtNomeSaida.Size = new System.Drawing.Size(213, 23);
            this.txtNomeSaida.TabIndex = 6;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(6, 33);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(92, 17);
            this.lblnome.TabIndex = 5;
            this.lblnome.Text = "Medicamento";
            // 
            // Controle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 630);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Controle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle";
            this.Load += new System.EventHandler(this.Controle_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisa)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rblQuantidade;
        private System.Windows.Forms.RadioButton rblPrincipioAtivo;
        private System.Windows.Forms.RadioButton rblNomeFantasia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.MaskedTextBox mktxtQuantidade;
        private System.Windows.Forms.TextBox txtPrincioAtivo;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.Label lblPrincipioAtivo;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtNomeMedicamento;
        private System.Windows.Forms.Label lblNomeMedicamento;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFimRegistro;
        private System.Windows.Forms.Label lblPagina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Anterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.DataGridView dgPesquisa;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MaskedTextBox mktQuantidadeSaida;
        private System.Windows.Forms.Label lblQuantidadeSaida;
        private System.Windows.Forms.TextBox txtNomeSaida;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Button btnRetirar;
        private System.Windows.Forms.TextBox txtValidadeSaida;
        private System.Windows.Forms.Label lblValidadeSaida;
        private System.Windows.Forms.Button btnLimpar;

    }
}