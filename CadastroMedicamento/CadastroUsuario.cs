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
    public partial class CadastroUsuario : Form
    {
        public string usuarioCorrente;
        public string controlePerfilUsuario;
        int codUsuario;
        Usuario objetoUsuario = new Usuario();
        
        public CadastroUsuario(string controlePerfilCorrente, string usuarioCorrente)
        {
            InitializeComponent();
            controlePerfilUsuario = controlePerfilCorrente;
        }

        public CadastroUsuario()
        {
            InitializeComponent();
            CarregarGridLogin();
            LimparCampos();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ValidacaoCadastroDuplicado();
            CarregarGridLogin(); 
            
        }

        private UsuarioAplicacao ValidacaoCadastroDuplicado()
        {
            var usuario = new Usuario();
            var produtoApp = UsuarioAplicacaoConstrutor.UsuarioAplicacaoProdutoRelatorioADO();

            if (ValidacaoCamposBrancos())
            {
                var lista = produtoApp.ListarTodosUsuarios();
                string codigoTemp = txtLogin.Text;
                var num = from num2 in lista
                          where num2.nomeUsuario.Equals(codigoTemp)
                          select num2.usuarioId;

                if (num.Count() >= 1)
                {
                    MessageBox.Show("Usuário já Cadastrado");
                }
                else
                {


                    usuario.nomeUsuario = txtLogin.Text;
                    usuario.senha = txtSenha.Text;
                    usuario.perfil = cbPerfil.Text;

                    produtoApp.SalvarUsuario(usuario);

                    MessageBox.Show("Gravação efetuada com Sucesso");
                }



            } return produtoApp;
        }

        private void CarregarGridLogin()
        {
          
                var produtoApp = UsuarioAplicacaoConstrutor.UsuarioAplicacaoProdutoRelatorioADO();

                IList<Usuario> listaUsuarios = new List<Usuario>();

                var lista = produtoApp.ListarTodosUsuarios();
                foreach (var item in lista)
                {
                    var usuario = new Usuario();
                    usuario.usuarioId = item.usuarioId;
                    usuario.nomeUsuario = item.nomeUsuario;
                    usuario.senha = item.senha;
                    usuario.perfil = item.perfil;
                    listaUsuarios.Add(usuario);

                }

                BindingSource banco = new BindingSource();
                banco.DataSource = listaUsuarios;
                dgCadastrarUsuario.DataSource = banco;
                dgCadastrarUsuario.Columns["usuarioId"].Visible = false;
           
            
           

        }

        private void dgCadastrarUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //var usuario = new Usuario();
            codUsuario = Convert.ToInt32(dgCadastrarUsuario.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtLogin.Text = dgCadastrarUsuario.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSenha.Text = dgCadastrarUsuario.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbPerfil.Text = dgCadastrarUsuario.Rows[e.RowIndex].Cells[3].Value.ToString();

            btnAlterar.Location = new Point(94, 167);
            btnCadastrar.Visible = false;
            btnAlterar.Visible = true;
            groupBox1.BackColor = Color.GreenYellow;
            groupBox1.Text = "Manutenção do Usuário";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();

        }

        private void LimparCampos()
        {
            txtLogin.Text = String.Empty;
            txtSenha.Text = String.Empty;
            cbPerfil.Text = String.Empty;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

            var formPrincipal = new Form1(controlePerfilUsuario,usuarioCorrente);

            if (controlePerfilUsuario.Equals("Usuario"))
            {
                formPrincipal.Visible = true;
                formPrincipal.cadastroDeUsuáriosToolStripMenuItem.Visible = false;
                formPrincipal.cadastroDeProdutosToolStripMenuItem.Visible = false;
            }
            else if (controlePerfilUsuario.Equals("Operador"))
            {
                formPrincipal.Visible = true;
                formPrincipal.cadastroDeUsuáriosToolStripMenuItem.Visible = false;
            }
            else if (controlePerfilUsuario.Equals("Administrador"))
            {
                formPrincipal.Visible = true;
            }
            


        }

        private void CadastroUsuario_Load(object sender, EventArgs e)
        {
            btnAlterar.Visible = false;
            btnCadastrar.Visible = true;
            groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            groupBox1.Text = "Cadastro de Usuário";
            LimparCampos();
            CarregarGridLogin();

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

            AlterarUsuario(sender,e);


        }

        private void AlterarUsuario(object sender, EventArgs e)
        {
           if (ValidacaoCamposBrancos())
	            {
                    var produtoApp = UsuarioAplicacaoConstrutor.UsuarioAplicacaoProdutoRelatorioADO();

                    objetoUsuario.usuarioId = codUsuario;
                    objetoUsuario.nomeUsuario = txtLogin.Text.Trim();
                    objetoUsuario.senha = txtSenha.Text.Trim();
                    objetoUsuario.perfil = cbPerfil.Text.Trim();

                    produtoApp.AlterarUsuario(objetoUsuario);
                    MessageBox.Show("Usuário alterado com Sucesso!");

                    CadastroUsuario_Load(sender, e);
	            }
           
        }

        private bool ValidacaoCamposBrancos()
        {
            if (String.IsNullOrWhiteSpace(txtLogin.Text.Trim()))
            {
                MessageBox.Show("Preencha Campo Login");
                txtLogin.Focus();
                return false;
            }
            else if (String.IsNullOrWhiteSpace(txtSenha.Text.Trim()))
            {
                MessageBox.Show("Preencha Campo Senha");
                txtSenha.Focus();
                return false;
            }
            else if (String.IsNullOrWhiteSpace(cbPerfil.Text.Trim()))
            {
                MessageBox.Show("Selecione um Perfil");
                cbPerfil.Focus();
                return false;
            }


            return true;
           
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (ValidacaoCamposBrancos())
            {
                var produtoApp = UsuarioAplicacaoConstrutor.UsuarioAplicacaoProdutoRelatorioADO();

                objetoUsuario.usuarioId = codUsuario;
                //objetoUsuario.nomeUsuario = txtLogin.Text.Trim();
                //objetoUsuario.senha = txtSenha.Text.Trim();
                //objetoUsuario.perfil = cbPerfil.Text.Trim();

                produtoApp.ExcluirUsuario(objetoUsuario);
                MessageBox.Show("Usuário Excluído com Sucesso!");

                CadastroUsuario_Load(sender, e);
            }
        }

       
    }
}
