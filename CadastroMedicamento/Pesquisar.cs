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
    public partial class Pesquisar : Form
    {
        int Deslocamento;
        int tamanhoPagina = 4;
        private int TotalRegistros;
        private int numeroDaPagina = 1;
        DataTable PaginTable = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();
        
         SqlConnection minhaConexao = null;
        

        //Conexao com o banco de dados
        public void Contexto1()
        {
            //instrução que recebe a conectionstring e realiza a conexao com o banco
            minhaConexao = new SqlConnection(ConfigurationManager.ConnectionStrings["stringConexao"].ConnectionString);
            minhaConexao.Open();
            

        }
        public Pesquisar()
        {
            InitializeComponent();
                   
        }

        public string usuarioCorrente;
        public string controlePerfilPesquisa;
        public Pesquisar(string controlePerfilCorrente, string usuarioCorrente)
        {
            InitializeComponent();
            controlePerfilPesquisa = controlePerfilCorrente;


        }

      

        //public string nome;
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PesquisarPorTipos();

        }

        public void PesquisarPadrao(object sender, EventArgs e)
        {
            InitializeComponent();
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
                    "SELECT produtoId,nome,principioAtivo,apresentacao,fabricante,dataValidade,dataFabricacao,quantidade,codigoBarras,dosagem,classeTerapeutica,estoqueMinimo FROM [Farmacia].[dbo].[Produto] where nome like '%{0}%'",
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

            Pesquisar_Load(sender, e);

        }

        public  void PesquisarPorTipos()
        {
            if (rblNomeFantasia.Checked)
            {

                   var produtoApp = UsuarioAplicacaoConstrutor.UsuarioAplicacaoADO();

                    string nomeSemCaracteresEspeciais = produtoApp.RemoverCaracteresEspeciais(txtNomeMedicamento.Text.Trim());
                    string nomeSemAcentos = produtoApp.RemoverAcentos(nomeSemCaracteresEspeciais);


                    if (String.IsNullOrWhiteSpace(txtNomeMedicamento.Text.Trim()))
                    {
                        MessageBox.Show("Campo de Pesquisa não pode ficar em branco!, Favor preencher.");
                        txtNomeMedicamento.Focus();
                    }
                    else
                    {

                        minhaConexao =
                                new SqlConnection(ConfigurationManager.ConnectionStrings["stringConexao"].ConnectionString);
                        minhaConexao.Open();
                        TotalRegistros =
                            RetornaQuantidadeDeRegistros(string.Format(
                                "Select Count(*) from Produto where nome like '%{0}%'", nomeSemAcentos));

                         var strQuery = "";
                    strQuery += string.Format("SELECT produtoId,nome as 'Nome do medicamento',principioAtivo as 'Principio Ativo',");
                    strQuery += string.Format("apresentacao as 'Apresentação',fabricante as 'Fabricante',dataValidade as 'Validade',");
                    strQuery += string.Format("dataFabricacao as 'FAbricação',quantidade as 'Qtd',codigoBarras as 'Código',");
                    strQuery += string.Format("dosagem as 'Dosagem',classeTerapeutica as 'Classe Terapêutica' FROM [Farmacia].[dbo].[Produto] where nome like '%{0}%'", nomeSemAcentos);
                    
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
            else if (rblPrincipioAtivo.Checked)
            {
               var produtoApp = UsuarioAplicacaoConstrutor.UsuarioAplicacaoADO();
                //var lista = produtoApp.ListarPorNomePaginando("principioAtivo",txtPrincioAtivo.Text.Trim());
                //var resultado = from listaTemp in lista
                //                where  SqlMethods.Like(listaTemp.principioAtivo,txtPrincioAtivo.Text.Trim() + "%") 
                //                select listaTemp;

                string nomeSemCaracteresEspeciais = produtoApp.RemoverCaracteresEspeciais(txtNomeMedicamento.Text.Trim());
                string nomeSemAcentos = produtoApp.RemoverAcentos(nomeSemCaracteresEspeciais);

                if (String.IsNullOrWhiteSpace(txtPrincipioAtivo.Text.Trim()))
                {
                    MessageBox.Show("Campo de Pesquisa não pode ficar em branco!, Favor preencher.");
                    txtPrincipioAtivo.Focus();
                }
                else
                {

                    minhaConexao =
                        new SqlConnection(ConfigurationManager.ConnectionStrings["stringConexao"].ConnectionString);
                    minhaConexao.Open();

                    TotalRegistros = RetornaQuantidadeDeRegistros(
                                string.Format("Select Count(*) from Produto where principioAtivo like '%{0}%'", nomeSemAcentos));
                    //var produtoApp = UsuarioAplicacaoConstrutor.UsuarioAplicacaoADO();
                    var strQuery = "";
                    strQuery += string.Format("SELECT produtoId,nome as 'Nome do medicamento',principioAtivo as 'Principio Ativo',");
                    strQuery += string.Format("apresentacao as 'Apresentação',fabricante as 'Fabricante',dataValidade as 'Validade',");
                    strQuery += string.Format("dataFabricacao as 'FAbricação',quantidade as 'Qtd',codigoBarras as 'Código',");
                    strQuery += string.Format("dosagem as 'Dosagem',classeTerapeutica as 'Classe Terapêutica' FROM [Farmacia].[dbo].[Produto] where principioAtivo like '%{0}%'", nomeSemAcentos);
                    
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
                
                    var strQuery = "";
                    strQuery += string.Format("SELECT produtoId,nome as 'Nome do medicamento',principioAtivo as 'Principio Ativo',");
                    strQuery += string.Format("apresentacao as 'Apresentação',fabricante as 'Fabricante',dataValidade as 'Validade',");
                    strQuery += string.Format("dataFabricacao as 'FAbricação',quantidade as 'Qtd',codigoBarras as 'Código',");
                    strQuery += string.Format("dosagem as 'Dosagem',classeTerapeutica as 'Classe Terapêutica' FROM [Farmacia].[dbo].[Produto] where quantidade like '%{0}%'",  mktxtQuantidade.Text.Trim());
                    
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
            else if (rblTudo.Checked) 
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

                var strQuery = "";
                    strQuery += string.Format("SELECT produtoId,nome as 'Nome do medicamento',principioAtivo as 'Principio Ativo',");
                    strQuery += string.Format("apresentacao as 'Apresentação',fabricante as 'Fabricante',dataValidade as 'Validade',");
                    strQuery += string.Format("dataFabricacao as 'FAbricação',quantidade as 'Qtd',codigoBarras as 'Código',");
                    strQuery += string.Format("dosagem as 'Dosagem',classeTerapeutica as 'Classe Terapêutica',estoqueMinimo FROM [Farmacia].[dbo].[Produto]");
                    
                //var lista = produtoApp.ListarPorNomePaginando("nome", );
                PaginTable = new DataTable();
                adapter = new SqlDataAdapter(strQuery, minhaConexao);
                adapter.Fill(PaginTable);
                BindingSource bd = new BindingSource();
                bd.DataSource = PaginTable;
                dgPesquisa.DataSource = bd;

                ConfigurarDataGrid();
                numeroDaPagina = 1;
                txtContador.Text = Convert.ToString(numeroDaPagina);
            }
        }

        private void rbNome_MouseCaptureChanged(object sender, EventArgs e)
        {
            lblPrincipioAtivo.Visible = false;
            txtPrincipioAtivo.Visible = false;
            

            lblQuantidade.Visible = false;
            mktxtQuantidade.Visible = false;

            
            lblNomeMedicamento.Visible = true;
            txtNomeMedicamento.Visible = true;
            txtNomeMedicamento.Enabled = true;
            txtNomeMedicamento.Focus();
            txtNomeMedicamento.BackColor = Color.White;

            txtNomeMedicamento.Location = new Point(145, 42);
            lblNomeMedicamento.Location = new Point(8,46);
        }

        private void rbPrincipio_MouseCaptureChanged(object sender, EventArgs e)
        {
            lblNomeMedicamento.Visible = false;
            txtNomeMedicamento.Visible = false;

            lblQuantidade.Visible = false;
            mktxtQuantidade.Visible = false;

            lblPrincipioAtivo.Visible = true;
            txtPrincipioAtivo.Visible = true;
            txtPrincipioAtivo.Enabled = true;
            txtPrincipioAtivo.Focus();
            txtPrincipioAtivo.BackColor = Color.White;

        }

        private void rbQuantidade_MouseCaptureChanged(object sender, EventArgs e)
        {
            lblNomeMedicamento.Visible = false;
            txtNomeMedicamento.Visible = false;
            lblPrincipioAtivo.Visible = false;
            txtPrincipioAtivo.Visible = false;

            lblQuantidade.Visible = true;
            mktxtQuantidade.Visible = true;
            mktxtQuantidade.Enabled = true;
            mktxtQuantidade.Focus();
            mktxtQuantidade.BackColor = Color.White;

            mktxtQuantidade.Location = new Point(145, 42);
            lblQuantidade.Location = new Point(23, 46);

        }

        private void rblTudo_MouseCaptureChanged(object sender, EventArgs e)
        {
            lblNomeMedicamento.Visible = false;
            txtNomeMedicamento.Visible = false;
           
            lblPrincipioAtivo.Visible = false;
            txtPrincipioAtivo.Visible = false;

            lblQuantidade.Visible = false;
            mktxtQuantidade.Visible = false;
            mktxtQuantidade.Enabled = false;
            
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
            dgPesquisa.Columns[7].HeaderCell.Size.Width.Equals(5);
            //dgPesquisa.Columns[8].HeaderText = "Código de Barras";

            dgPesquisa.Columns["produtoId"].Visible = false;
            
            
        }

        private void Pesquisar_Load(object sender, EventArgs e)
        {
            rblNomeFantasia.Checked = true;
            if (rblNomeFantasia.Checked == true)
            {
                txtNomeMedicamento.Enabled = true;
            }
            txtPrincipioAtivo.Enabled = false;
            txtPrincipioAtivo.Visible = false;
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
            
            var formPrincipal = new Form1(controlePerfilPesquisa,usuarioCorrente);
            if (controlePerfilPesquisa.Equals("Usuario"))
            {
                formPrincipal.Visible = true;
                formPrincipal.cadastroDeUsuáriosToolStripMenuItem.Enabled = false;
                formPrincipal.cadastroDeProdutosToolStripMenuItem.Enabled = false;
            }
            else if (controlePerfilPesquisa.Equals("Operador"))
            {
                formPrincipal.Visible = true;
                formPrincipal.cadastroDeUsuáriosToolStripMenuItem.Enabled = false;
            }
            else if(controlePerfilPesquisa.Equals("Administrador"))
            {
                formPrincipal.Visible = true;
            }
            
        }

       

      

        private void CarregarProdutosVencidos()
        {

            var produtoApp = UsuarioAplicacaoConstrutor.UsuarioAplicacaoADO();
            
            IList<Produto> listaProduto = new List<Produto>();
            var t = DateTime.Now;
            
            var lista = produtoApp.ListarTodos();
            foreach (var item in lista)
            {
                var produto = new Produto();
                produto.nome           = item.nome;
                produto.apresentacao   = item.apresentacao;
                produto.fabricante     = item.fabricante;
                produto.principioAtivo = item.principioAtivo;
                produto.dataValidade =   DateTime.Parse(String.Format("{0:d}", item.dataValidade));
                produto.dataFabricacao = item.dataFabricacao;
                produto.quantidade     = item.quantidade;
                produto.codigoBarras   = item.codigoBarras;
                produto.dosagem = item.dosagem;
                produto.classeTerapeutica = item.classeTerapeutica;
                
                DateTime DataAtual = DateTime.Now;



                TimeSpan diferencaEntreDatas = DataAtual - produto.dataValidade;
                
                int diferenca = diferencaEntreDatas.Days;
                int diferencaTemp = Math.Abs(diferenca);
               
                if (diferencaTemp <= 30 )
                {
                    listaProduto.Add(produto);
                     
                }
                
                
               
            }

            BindingSource banco = new BindingSource();
            banco.DataSource = listaProduto;
            if (listaProduto.Count == 0)
            {
                MessageBox.Show("Não existem Medicamentos com prazo de validade igual ou inferior a 30 dias.");
            }
            else
            {

                dgProdutoDataVencendo.DataSource = banco;
                dgProdutoDataVencendo.Columns["produtoId"].Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarregarProdutosVencidos();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            Avancar();
        }

        private void Avancar()
        {
            numeroDaPagina = numeroDaPagina + 1;
            txtContador.Text = Convert.ToString(numeroDaPagina);
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
            txtContador.Text = Convert.ToString(numeroDaPagina);
            Deslocamento = Deslocamento - tamanhoPagina;
            if (Deslocamento <= 0)
            {
                Deslocamento = 0;
            }
            PaginTable.Clear();
            adapter.Fill(Deslocamento, tamanhoPagina, PaginTable);

            ConfigurarDataGrid();
        }

        private void dgPesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var produto = new Produto();
            //this.Hide();
           // int v = Convert.ToInt32(dgPesquisa.Rows[e.RowIndex].Cells[0].Value.ToString());

            if (teste < 0) 
            {
                teste = 1;
            }
            else
            {

                produto.produtoId = Convert.ToInt32(dgPesquisa.Rows[e.RowIndex].Cells[0].Value);
                produto.nome = dgPesquisa.Rows[e.RowIndex].Cells[1].Value.ToString();
                produto.principioAtivo = dgPesquisa.Rows[e.RowIndex].Cells[2].Value.ToString();
                produto.apresentacao = dgPesquisa.Rows[e.RowIndex].Cells[3].Value.ToString();
                produto.fabricante = dgPesquisa.Rows[e.RowIndex].Cells[4].Value.ToString();
                produto.dataValidade = Convert.ToDateTime(dgPesquisa.Rows[e.RowIndex].Cells[5].Value.ToString());
                produto.dataFabricacao = Convert.ToDateTime(dgPesquisa.Rows[e.RowIndex].Cells[6].Value.ToString());
                produto.quantidade = Convert.ToInt32(dgPesquisa.Rows[e.RowIndex].Cells[7].Value.ToString());
                produto.codigoBarras = dgPesquisa.Rows[e.RowIndex].Cells[8].Value.ToString();
                produto.dosagem = dgPesquisa.Rows[e.RowIndex].Cells[9].Value.ToString();
                produto.classeTerapeutica = dgPesquisa.Rows[e.RowIndex].Cells[10].Value.ToString();
                produto.estoqueMinimo = Convert.ToInt32(dgPesquisa.Rows[e.RowIndex].Cells[11].Value.ToString());

                Editar formEditar = new Editar(produto);
                formEditar.ShowDialog();
            }
        }
        int teste;
        private void dgPesquisa_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            teste = -1;
            btnPesquisar.Focus();
        }

        private void dgPesquisa_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            teste = -1;
            btnPesquisar.Focus();
        }

      
       

       

        
    }
}
