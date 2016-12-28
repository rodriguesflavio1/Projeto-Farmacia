using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Aplicacao;
using Biblioteca.Dominio;

namespace CadastroMedicamento
{
    public partial class Login : Form
    {
        public string controlePerfil;
        public string nomeUsuarioCorrente;
        
        public Login()
        {
            InitializeComponent();
            txtLogin.Focus();
            txtLogin.Select();
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            var produtoApp = UsuarioAplicacaoConstrutor.UsuarioAplicacaoUsuarioADO();


            var lista = produtoApp.ListarPorNomeUsuario(txtLogin.Text,txtSenha.Text);
                        
                          
            foreach (var item in lista)
	        {
		         usuario.perfil = item.perfil;
                 usuario.nomeUsuario = item.nomeUsuario;
	        }
            controlePerfil = usuario.perfil;
            nomeUsuarioCorrente = usuario.nomeUsuario;

            
            if (lista.Count() >= 1)
                {
                   
                        Form1 formPrincipal = new Form1(controlePerfil,nomeUsuarioCorrente);
                        
                    if (usuario.perfil.Equals("Administrador"))
                    {
                        formPrincipal.Show();
                        this.Hide();
                        
                    
                    }else if(usuario.perfil.Equals("Operador"))
                    {
                        this.Hide();
                        formPrincipal.Show();
                        formPrincipal.cadastroDeUsuáriosToolStripMenuItem.Enabled = false;

                    }else if(usuario.perfil.Equals("Usuario"))
                    {
                        this.Hide();                        
                        formPrincipal.Show();
                        formPrincipal.cadastroDeUsuáriosToolStripMenuItem.Enabled = false;
                        formPrincipal.cadastroDeProdutosToolStripMenuItem.Enabled = false;
                        
                    }
                    
                        
                   
                    
                }
                else
                {

                    MessageBox.Show("Usuário ou Senha Incorretos!");
                }



            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAcessar_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void btnAcessar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnAcessar.PerformClick();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtLogin.Focus();
        }

        

       

        
    }
}
