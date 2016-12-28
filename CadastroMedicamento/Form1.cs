using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroMedicamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        public string usuarioCorrente;
        public string controlePerfilCorrente;
        public Form1(string controlePerfil,string usuarioCorrente)
        {
            InitializeComponent();
            controlePerfilCorrente = controlePerfil;
            toolStripStatusUsuario.Text = usuarioCorrente;
            toolStripStatusPerfil.Text = controlePerfil;
            DateTime data = DateTime.Today;
            lblData.Text = data.ToString("d");
            
        }
      
        
        private void Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formPes = new Pesquisar(controlePerfilCorrente,usuarioCorrente);
            formPes.Visible = true;
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formCad = new TelaCadastro(controlePerfilCorrente,usuarioCorrente);
            formCad.Visible = true;
        }

        private void btnSaidaDeMedicamento_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formControle = new Controle(controlePerfilCorrente,usuarioCorrente);
            formControle.Visible = true;

        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formCad = new CadastroUsuario(controlePerfilCorrente,usuarioCorrente);
            formCad.Visible = true;
        }

        private void cadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formCad = new TelaCadastro(controlePerfilCorrente,usuarioCorrente);
            formCad.Visible = true;
        }

        private void cadastroDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formCad = new CadastroUsuario(controlePerfilCorrente, usuarioCorrente);
            formCad.Visible = true;
        }

        private void saídaDeMedicamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formControle = new Controle(controlePerfilCorrente,usuarioCorrente);
            formControle.Visible = true;
        }

        private void pesquisarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form formPes = new Pesquisar(controlePerfilCorrente, usuarioCorrente);
            formPes.Visible = true;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblRelogio.Text = DateTime.Now.ToString("HH:mm:ss");
        }

       
       

       
    }
}
