using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using Biblioteca.Aplicacao;
using Biblioteca.Dominio;
using System.Configuration;

namespace CadastroMedicamento
{
    public partial class Controle : Form
    {

        //Variaveis globais utilizadas para controle e acesso ao banco
        private int produtoId;
        int Deslocamento;
        int tamanhoPagina = 4;
        private int TotalRegistros;
        private int numeroDaPagina = 1;
        DataTable PaginTable = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlConnection minhaConexao = null;
        //Variavel para controle de saída do produto
        int valorQuantidadeNoEstoque;

        ProdutoRelatorio produtoRelatorio = new ProdutoRelatorio();

        public void Contexto1()
        {
            //instrução que recebe a conectionstring e realiza a conexao com o banco
            minhaConexao = new SqlConnection(ConfigurationManager.ConnectionStrings["stringConexao"].ConnectionString);
            minhaConexao.Open();


        }

        public Controle()
        {
            InitializeComponent();
            
        }

        public string controlePerfilControle;
        public string usuarioCorrente;
        public Controle(string controlePerfilCorrente,string usuarioCorrente)
        {
            InitializeComponent();
            controlePerfilControle = controlePerfilCorrente;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarPorTipos();
        }
        public void PesquisarPorTipos()
        {
            if (rblNomeFantasia.Checked)
            {

                var produtoApp = UsuarioAplicacaoConstrutor.UsuarioAplicacaoADO();

                string nomeSemCaracteresEspeciais = produtoApp.RemoverCaracteresEspeciais(txtNomeMedicamento.Text.Trim());
                string nomeSemAcentos = produtoApp.RemoverAcentos(nomeSemCaracteresEspeciais);
                minhaConexao =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["stringConexao"].ConnectionString);
                minhaConexao.Open();
                TotalRegistros =
                    RetornaQuantidadeDeRegistros(string.Format(
                        "Select Count(*) from Produto where nome like '%{0}%'", nomeSemAcentos));

                string strQuery =
                    string.Format(
                        "SELECT produtoId,nome,principioAtivo,apresentacao,fabricante,dataValidade,dataFabricacao,quantidade,codigoBarras FROM [Farmacia].[dbo].[Produto] where nome like '%{0}%'",
                        nomeSemAcentos);
                //var lista = produtoApp.ListarPorNomePaginando("nome", );
                PaginTable = new DataTable();
                adapter = new SqlDataAdapter(strQuery, minhaConexao);
                adapter.Fill(Deslocamento, tamanhoPagina, PaginTable);
                BindingSource bd = new BindingSource();
                bd.DataSource = PaginTable;
                dgPesquisa.DataSource = bd;

                ConfigurarDataGrid();
                numeroDaPagina = 1;
                lblPagina.Text = Convert.ToString(numeroDaPagina);


            }
            else if (rblPrincipioAtivo.Checked)
            {
                var produtoApp = UsuarioAplicacaoConstrutor.UsuarioAplicacaoADO();
                //var lista = produtoApp.ListarPorNomePaginando("principioAtivo",txtPrincioAtivo.Text.Trim());
                //var resultado = from listaTemp in lista
                //                where  SqlMethods.Like(listaTemp.principioAtivo,txtPrincioAtivo.Text.Trim() + "%") 
                //                select listaTemp;

                string nomeSemCaracteresEspeciais = produtoApp.RemoverCaracteresEspeciais(txtNomeMedicamento.Text.Trim());
                string nomeSemAcentos = produtoApp.RemoverAcentos(nomeSemCaracteresEspeciais);

                minhaConexao =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["stringConexao"].ConnectionString);
                minhaConexao.Open();

                TotalRegistros = RetornaQuantidadeDeRegistros(
                            string.Format("Select Count(*) from Produto where principioAtivo like '%{0}%'", nomeSemAcentos));
                //var produtoApp = UsuarioAplicacaoConstrutor.UsuarioAplicacaoADO();

                string strQuery =
                    string.Format(
                        "SELECT produtoId,nome,principioAtivo,apresentacao,fabricante,dataValidade,dataFabricacao,quantidade,codigoBarras FROM [Farmacia].[dbo].[Produto] where principioAtivo like '%{0}%'",
                        nomeSemAcentos);
                //var lista = produtoApp.ListarPorNomePaginando("nome", );
                PaginTable = new DataTable();
                adapter = new SqlDataAdapter(strQuery, minhaConexao);
                adapter.Fill(Deslocamento, tamanhoPagina, PaginTable);
                BindingSource bd = new BindingSource();
                bd.DataSource = PaginTable;
                dgPesquisa.DataSource = bd;

                ConfigurarDataGrid();
                numeroDaPagina = 1;
                lblPagina.Text = Convert.ToString(numeroDaPagina);


            }
            else if (rblQuantidade.Checked)
            {
                //var produtoApp = UsuarioAplicacaoConstrutor.UsuarioAplicacaoADO();

                //var nome = Convert.ToInt32(mktxtQuantidade.Text);
                //var lista = produtoApp.ListarTodos();

                //var resultado = from listaTemp in lista
                //    where listaTemp.quantidade == nome
                //    select listaTemp;
                if (String.IsNullOrWhiteSpace(mktxtQuantidade.Text.Trim()))
                {
                    MessageBox.Show("Campo de Pesquisa não pode ficar em branco!, Favor preencher.");
                    mktxtQuantidade.Focus();
                }
                else
                {

                    minhaConexao =
                        new SqlConnection(ConfigurationManager.ConnectionStrings["stringConexao"].ConnectionString);
                    minhaConexao.Open();
                    TotalRegistros =
                        RetornaQuantidadeDeRegistros(string.Format("Select Count(*) from Produto where quantidade  '{0}'",
                            mktxtQuantidade.Text.Trim()));
                    //var produtoApp = UsuarioAplicacaoConstrutor.UsuarioAplicacaoADO();
                    string strQuery =
                        string.Format(
                            "SELECT produtoId,nome,principioAtivo,apresentacao,fabricante,dataValidade,dataFabricacao,quantidade,codigoBarras FROM [Farmacia].[dbo].[Produto] where quantidade  '{0}'",
                            mktxtQuantidade.Text.Trim());
                    //var lista = produtoApp.ListarPorNomePaginando("nome", );
                    PaginTable = new DataTable();
                    adapter = new SqlDataAdapter(strQuery, minhaConexao);
                    adapter.Fill(Deslocamento, tamanhoPagina, PaginTable);
                    BindingSource bd = new BindingSource();
                    bd.DataSource = PaginTable;
                    dgPesquisa.DataSource = bd;

                    ConfigurarDataGrid();
                    numeroDaPagina = 1;
                    lblPagina.Text = Convert.ToString(numeroDaPagina);
                }
            }
        }

        private void rblNomeFantasia_MouseCaptureChanged(object sender, EventArgs e)
        {
            lblPrincipioAtivo.Visible = false;
            txtPrincioAtivo.Visible = false;


            lblQuantidade.Visible = false;
            mktxtQuantidade.Visible = false;


            lblNomeMedicamento.Visible = true;
            txtNomeMedicamento.Visible = true;
            txtNomeMedicamento.Enabled = true;
            txtNomeMedicamento.Focus();
            txtNomeMedicamento.BackColor = Color.White;

            txtNomeMedicamento.Location = new Point(145, 42);
            lblNomeMedicamento.Location = new Point(8, 46);
        }

        private void rblPrincipioAtivo_MouseCaptureChanged(object sender, EventArgs e)
        {
            lblNomeMedicamento.Visible = false;
            txtNomeMedicamento.Visible = false;

            lblQuantidade.Visible = false;
            mktxtQuantidade.Visible = false;

            lblPrincipioAtivo.Visible = true;
            txtPrincioAtivo.Visible = true;
            txtPrincioAtivo.Enabled = true;
            txtPrincioAtivo.Focus();
            txtPrincioAtivo.BackColor = Color.White;
        }

        private void rblQuantidade_MouseCaptureChanged(object sender, EventArgs e)
        {
            lblNomeMedicamento.Visible = false;
            txtNomeMedicamento.Visible = false;
            lblPrincipioAtivo.Visible = false;
            txtPrincioAtivo.Visible = false;

            lblQuantidade.Visible = true;
            mktxtQuantidade.Visible = true;
            mktxtQuantidade.Enabled = true;
            mktxtQuantidade.Focus();
            mktxtQuantidade.BackColor = Color.White;

            mktxtQuantidade.Location = new Point(145, 42);
            lblQuantidade.Location = new Point(23, 46);
        }

        private void ConfigurarDataGrid()
        {
            //dgPesquisa.Columns[0].HeaderText ="Código";
            //dgPesquisa.Columns[1].HeaderText = "Nome";
            //dgPesquisa.Columns[2].HeaderText = "Principio Ativo";
            //dgPesquisa.Columns[3].HeaderText = "Apresentação";
            //dgPesquisa.Columns[4].HeaderText = "Fabricante";
            //dgPesquisa.Columns[5].HeaderText = "Data de Validade";
            //dgPesquisa.Columns[6].HeaderText = "Data de Fabricação";
            //dgPesquisa.Columns[7].HeaderText = "Quantidade";
            //dgPesquisa.Columns[8].HeaderText = "Código de Barras";

            dgPesquisa.Columns["produtoId"].Visible = false;
        }

        private void Controle_Load(object sender, EventArgs e)
        {
            rblNomeFantasia.Checked = true;
            if (rblNomeFantasia.Checked == true)
            {
                txtNomeMedicamento.Enabled = true;
            }
            txtPrincioAtivo.Enabled = false;
            txtPrincioAtivo.Visible = false;
            lblPrincipioAtivo.Visible = false;
            // txtPrincioAtivo.BackColor = Color.MediumPurple;
            //txtNomeMedicamento.Enabled = false;
            //txtNomeMedicamento.BackColor = Color.MediumPurple;
            mktxtQuantidade.Enabled = false;
            mktxtQuantidade.Visible = false;
            lblQuantidade.Visible = false;
            //mktxtQuantidade.BackColor = Color.MediumPurple;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();

            var formPrincipal = new Form1(controlePerfilControle, usuarioCorrente);
            if (controlePerfilControle.Equals("Usuario"))
            {
                formPrincipal.Visible = true;
                formPrincipal.cadastroDeUsuáriosToolStripMenuItem.Enabled = false;
                formPrincipal.cadastroDeProdutosToolStripMenuItem.Enabled = false;
            }
            else if (controlePerfilControle.Equals("Operador"))
            {
                formPrincipal.Visible = true;
                formPrincipal.cadastroDeUsuáriosToolStripMenuItem.Enabled = false;
            }
            else if(controlePerfilControle.Equals("Administrador"))
            {
                formPrincipal.Visible = true;
            }
        }

        private void dgPesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var produto = new Produto();
            //this.Hide();

            
            produtoId = Convert.ToInt32(dgPesquisa.Rows[e.RowIndex].Cells[0].Value);
            txtNomeSaida.Text = dgPesquisa.Rows[e.RowIndex].Cells[1].Value.ToString();
            produtoRelatorio.principioAtivo = dgPesquisa.Rows[e.RowIndex].Cells[2].Value.ToString();
            //produto.apresentacao = dgPesquisa.Rows[e.RowIndex].Cells[3].Value.ToString();
            //produto.fabricante = dgPesquisa.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtValidadeSaida.Text = dgPesquisa.Rows[e.RowIndex].Cells[5].Value.ToString();
            //produto.dataFabricacao = Convert.ToDateTime(dgPesquisa.Rows[e.RowIndex].Cells[6].Value.ToString());
            valorQuantidadeNoEstoque = Convert.ToInt32(dgPesquisa.Rows[e.RowIndex].Cells[7].Value.ToString());
            //produto.codigoBarras = dgPesquisa.Rows[e.RowIndex].Cells[8].Value.ToString();

          
            
            mktQuantidadeSaida.Enabled = true;
            btnRetirar.Enabled = true;

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            Avancar();
        }

        private void Avancar()
        {
            numeroDaPagina = numeroDaPagina + 1;
            lblPagina.Text = Convert.ToString(numeroDaPagina);
            Deslocamento = Deslocamento + tamanhoPagina;
            if (Deslocamento >= TotalRegistros)
            {
                PaginTable.Clear();
                adapter.Fill(Deslocamento, tamanhoPagina, PaginTable);
                ConfigurarDataGrid();
                btnProximo.Enabled = false;
                lblFimRegistro.Text = "Não Existe mais Registro.Click no botão Voltar!";
            }
            else
            {

                PaginTable.Clear();
                adapter.Fill(Deslocamento, tamanhoPagina, PaginTable);

                ConfigurarDataGrid();
            }
        }
        
        public int RetornaQuantidadeDeRegistros(string QueryQuantidade)
        {


            using (SqlCommand command = new SqlCommand(QueryQuantidade, minhaConexao))
            {
                return Convert.ToInt32(command.ExecuteScalar());
            }

        }

        private void Anterior_Click(object sender, EventArgs e)
        {
            lblFimRegistro.Text = String.Empty;
            btnProximo.Enabled = true;
            numeroDaPagina = numeroDaPagina - 1;
            if (numeroDaPagina < 1)
            {
                numeroDaPagina = 1;
            }
            lblPagina.Text = Convert.ToString(numeroDaPagina);
            Deslocamento = Deslocamento - tamanhoPagina;
            if (Deslocamento <= 0)
            {
                Deslocamento = 0;
            }
            PaginTable.Clear();
            adapter.Fill(Deslocamento, tamanhoPagina, PaginTable);

            ConfigurarDataGrid();
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
           ValidacaoCamposBrancos();
        }

        //Método controla a retirada do produto
        private void ControleDeRetiradaDeMedicamento()
        {
            int valorTemporario;
            int novoValorNoEstoque;
            Produto objetoProduto = new Produto();
           
            var produtoApp = UsuarioAplicacaoConstrutor.UsuarioAplicacaoADO();


            valorTemporario = Convert.ToInt32(mktQuantidadeSaida.Text);
            

            if (valorTemporario > valorQuantidadeNoEstoque)
            {
                MessageBox.Show("Valor a Retirar maior que o encontrado no estoque!");
                mktQuantidadeSaida.Focus();
            }
            else
            {
                novoValorNoEstoque = valorQuantidadeNoEstoque - valorTemporario;

                objetoProduto.quantidade = novoValorNoEstoque;
                objetoProduto.produtoId = produtoId;
                InserirTabelaProdutoRelatorio();
                produtoApp.AlterarQuantidade(objetoProduto);
                MessageBox.Show("Saida de Medicamento efetuada com Sucesso!");
                txtNomeSaida.Clear();
                txtValidadeSaida.Clear();
                mktQuantidadeSaida.Clear();
                
                AtualizarGrid();
            }
        }

        //Método insere dados na tabela de produtorelatorio
        private void InserirTabelaProdutoRelatorio() 
        {
            var produtoApp = UsuarioAplicacaoConstrutor.UsuarioAplicacaoProdutoRelatorioADO();

            try
            {
                produtoRelatorio.dataRetirada = DateTime.Today;
                produtoRelatorio.nome = txtNomeSaida.Text;
                produtoRelatorio.quantidade = Convert.ToInt32(mktQuantidadeSaida.Text);
            
                produtoApp.InserirProdutoRelatorio(produtoRelatorio);
                MessageBox.Show("Inserido no Relatorio");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
           

           


        }

        public void AtualizarGrid()
        {
            if (rblNomeFantasia.Checked)
            {

                var produtoApp = UsuarioAplicacaoConstrutor.UsuarioAplicacaoADO();

                string nomeSemCaracteresEspeciais = produtoApp.RemoverCaracteresEspeciais(txtNomeMedicamento.Text.Trim());
                string nomeSemAcentos = produtoApp.RemoverAcentos(nomeSemCaracteresEspeciais);
                minhaConexao =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["stringConexao"].ConnectionString);
                minhaConexao.Open();
                TotalRegistros =
                    RetornaQuantidadeDeRegistros(string.Format(
                        "Select Count(*) from Produto where nome like '%{0}%'", nomeSemAcentos));

                string strQuery =
                    string.Format(
                        "SELECT produtoId,nome,principioAtivo,apresentacao,fabricante,dataValidade,dataFabricacao,quantidade,codigoBarras FROM [Farmacia].[dbo].[Produto] where nome like '%{0}%'",
                        nomeSemAcentos);
                //var lista = produtoApp.ListarPorNomePaginando("nome", );
                PaginTable = new DataTable();
                adapter = new SqlDataAdapter(strQuery, minhaConexao);
                adapter.Fill(Deslocamento, tamanhoPagina, PaginTable);
                BindingSource bd = new BindingSource();
                bd.DataSource = PaginTable;
                dgPesquisa.DataSource = bd;

                ConfigurarDataGrid();
                numeroDaPagina = 1;
                lblPagina.Text = Convert.ToString(numeroDaPagina);


            }
            else if (rblPrincipioAtivo.Checked)
            {
                var produtoApp = UsuarioAplicacaoConstrutor.UsuarioAplicacaoADO();
                //var lista = produtoApp.ListarPorNomePaginando("principioAtivo",txtPrincioAtivo.Text.Trim());
                //var resultado = from listaTemp in lista
                //                where  SqlMethods.Like(listaTemp.principioAtivo,txtPrincioAtivo.Text.Trim() + "%") 
                //                select listaTemp;

                string nomeSemCaracteresEspeciais = produtoApp.RemoverCaracteresEspeciais(txtNomeMedicamento.Text.Trim());
                string nomeSemAcentos = produtoApp.RemoverAcentos(nomeSemCaracteresEspeciais);

                minhaConexao =
                    new SqlConnection(ConfigurationManager.ConnectionStrings["stringConexao"].ConnectionString);
                minhaConexao.Open();

                TotalRegistros = RetornaQuantidadeDeRegistros(
                            string.Format("Select Count(*) from Produto where principioAtivo like '%{0}%'", nomeSemAcentos));
                //var produtoApp = UsuarioAplicacaoConstrutor.UsuarioAplicacaoADO();

                string strQuery =
                    string.Format(
                        "SELECT produtoId,nome,principioAtivo,apresentacao,fabricante,dataValidade,dataFabricacao,quantidade,codigoBarras FROM [Farmacia].[dbo].[Produto] where principioAtivo like '%{0}%'",
                        nomeSemAcentos);
                //var lista = produtoApp.ListarPorNomePaginando("nome", );
                PaginTable = new DataTable();
                adapter = new SqlDataAdapter(strQuery, minhaConexao);
                adapter.Fill(Deslocamento, tamanhoPagina, PaginTable);
                BindingSource bd = new BindingSource();
                bd.DataSource = PaginTable;
                dgPesquisa.DataSource = bd;

                ConfigurarDataGrid();
                numeroDaPagina = 1;
                lblPagina.Text = Convert.ToString(numeroDaPagina);


            }
            else if (rblQuantidade.Checked)
            {
                //var produtoApp = UsuarioAplicacaoConstrutor.UsuarioAplicacaoADO();

                //var nome = Convert.ToInt32(mktxtQuantidade.Text);
                //var lista = produtoApp.ListarTodos();

                //var resultado = from listaTemp in lista
                //    where listaTemp.quantidade == nome
                //    select listaTemp;
                if (String.IsNullOrWhiteSpace(mktxtQuantidade.Text.Trim()))
                {
                    MessageBox.Show("Campo de Pesquisa não pode ficar em branco!, Favor preencher.");
                    mktxtQuantidade.Focus();
                }
                else
                {

                    minhaConexao =
                        new SqlConnection(ConfigurationManager.ConnectionStrings["stringConexao"].ConnectionString);
                    minhaConexao.Open();
                    TotalRegistros =
                        RetornaQuantidadeDeRegistros(string.Format("Select Count(*) from Produto where quantidade  '{0}'",
                            mktxtQuantidade.Text.Trim()));
                    //var produtoApp = UsuarioAplicacaoConstrutor.UsuarioAplicacaoADO();
                    string strQuery =
                        string.Format(
                            "SELECT produtoId,nome,principioAtivo,apresentacao,fabricante,dataValidade,dataFabricacao,quantidade,codigoBarras FROM [Farmacia].[dbo].[Produto] where quantidade  '{0}'",
                            mktxtQuantidade.Text.Trim());
                    //var lista = produtoApp.ListarPorNomePaginando("nome", );
                    PaginTable = new DataTable();
                    adapter = new SqlDataAdapter(strQuery, minhaConexao);
                    adapter.Fill(Deslocamento, tamanhoPagina, PaginTable);
                    BindingSource bd = new BindingSource();
                    bd.DataSource = PaginTable;
                    dgPesquisa.DataSource = bd;

                    ConfigurarDataGrid();
                    numeroDaPagina = 1;
                    lblPagina.Text = Convert.ToString(numeroDaPagina);
                }
            }
        }

        private void ValidacaoCamposBrancos()
        {
           
            if (String.IsNullOrWhiteSpace(mktQuantidadeSaida.Text.Trim()))
            {
                MessageBox.Show("Preencher Campo Quantidade");
                mktQuantidadeSaida.Focus();
            }
            else
            {
                ControleDeRetiradaDeMedicamento();
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos(this);
        }
        private void LimparCampos(Control PanelID)
        {
            foreach (Control item in PanelID.Controls)
            {
                if (item is TextBox)
                {
                    TextBox questionTextBox = item as TextBox;
                    if (questionTextBox != null)
                    {
                        questionTextBox.Text = String.Empty;
                    }
                }
                if (item is ComboBox)
                {

                    ComboBox questionTextBox = item as ComboBox;
                    if (questionTextBox != null)
                    {
                        questionTextBox.Text = String.Empty;
                    }
                } if (item is MaskedTextBox)
                {

                    MaskedTextBox questionTextBox = item as MaskedTextBox;
                    if (questionTextBox != null)
                    {
                        questionTextBox.Text = String.Empty;
                    }
                }

                if (item.Controls.Count > 0)
                {
                    LimparCampos(item);
                }
            }
        }
    }
}
