using System;
using System.Collections;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Biblioteca.Aplicacao;
using Biblioteca.Dominio;



namespace CadastroMedicamento
{
    public partial class TelaCadastro : Form
    {

        public TelaCadastro()
        {
            InitializeComponent();
            
        }

        public string usuarioCorrente;
        public string controlePerfilCadastro;
        public TelaCadastro(string controlePerfilCorrente, string usuarioCorrente)
        {
            InitializeComponent();
            controlePerfilCadastro = controlePerfilCorrente;
        }

        private void TelaCadastro_Load(object sender, EventArgs e)
        {

          

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos(this);
           
        }

       

        private void btnGravar_Click(object sender, EventArgs e)
        {
            ValidacaoCamposBrancos();
            LimparCampos(this);
        }

      

        private UsuarioAplicacao ValidacaoCadastroDuplicado()
        {
            var produtoApp = UsuarioAplicacaoConstrutor.UsuarioAplicacaoADO();

            var lista = produtoApp.ListarTodos();
            string codigoTemp = txtCodigoBarras.Text;
            var num = from num2 in lista
                where num2.codigoBarras == codigoTemp
                select num2.produtoId;

            if (num.Count() >= 1)
            {
                MessageBox.Show("Produto já Cadastrado");
            }
            else
            {
                var produto = new Produto();

                produto.nome = produtoApp.RemoverCaracteresEspeciais(txtNome.Text.ToUpper());
                produto.apresentacao = produtoApp.RemoverCaracteresEspeciais(txtFormaFarmaceutica.Text.ToUpper());
                produto.fabricante = produtoApp.RemoverCaracteresEspeciais(txtFabricante.Text.ToUpper());
                produto.principioAtivo = produtoApp.RemoverCaracteresEspeciais(txtPrincipioAtivo.Text.ToUpper());
                produto.quantidade = Convert.ToInt32(txtQuantidade.Text.ToString());
                produto.dataFabricacao = DateTime.ParseExact(dtpFabricacao.Text, "MM/yyyy", CultureInfo.InvariantCulture);
                produto.dataValidade = DateTime.ParseExact(dtpValidacao.Text, "MM/yyyy", CultureInfo.InvariantCulture);
                produto.codigoBarras = txtCodigoBarras.Text.ToString();
                produto.classeTerapeutica = cbClasseTerapeutica.Text.ToUpper();
                produto.dosagem = cbDosagem.Text.ToUpper();
                produto.estoqueMinimo = Convert.ToInt32(mkEstoqueMinimo.Text);
                
                
                produtoApp.Salvar(produto);

                MessageBox.Show("Gravação efetuada com Sucesso");
            }


            return produtoApp;
        }

        

        //Método Limpar campos usando o controle 
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
                       
                       ComboBox  questionTextBox = item as ComboBox;
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

                    if(item.Controls.Count > 0)
                    {
                        LimparCampos(item);
                    }
                }
            }

        //Verifica se todos os campos foram preenchidos
        private void ValidacaoCamposBrancos()
        {
            if (String.IsNullOrWhiteSpace(txtNome.Text.Trim()))
            {
                MessageBox.Show("Preencher Campo Nome");
                txtNome.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtCodigoBarras.Text.Trim()))
            {
                MessageBox.Show("Preencher Campo com o Código de Barras");
                txtFabricante.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtFabricante.Text.Trim()))
            {
                MessageBox.Show("Preencher Campo com o Nome do Fabricante");
                txtFabricante.Focus();
            }
           
            else if (String.IsNullOrWhiteSpace(txtFormaFarmaceutica.Text.Trim()))
            {
                MessageBox.Show("Preencher Campo Forma Farmacêutica");
                txtFormaFarmaceutica.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtPrincipioAtivo.Text.Trim()))
            {
                MessageBox.Show("Preencher Campo Nome do Principio Ativo");
                txtPrincipioAtivo.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtCodigoBarras.Text.Trim()))
            {
                MessageBox.Show("Preencher Campo com Código de Barras");
                txtCodigoBarras.Focus();
            }
            else if (String.IsNullOrWhiteSpace(dtpValidacao.Text.Trim()))
            {
                MessageBox.Show("Preencher Campo com a Data de Validade");
                dtpValidacao.Focus();
            }
            else if (String.IsNullOrWhiteSpace(dtpFabricacao.Text.Trim()))
            {
                MessageBox.Show("Preencher Campo com a Data de Fabricação");
                dtpValidacao.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtQuantidade.Text.Trim()))
            {
                MessageBox.Show("Preencher Campo com a Data de Fabricação");
                dtpValidacao.Focus();
            }
            else if (String.IsNullOrWhiteSpace(cbClasseTerapeutica.Text.Trim()))
            {
                MessageBox.Show("Preencher Campo Classe Terapêutica");
                cbClasseTerapeutica.Focus();
            }
            else if (String.IsNullOrWhiteSpace(cbDosagem.Text.Trim()))
            {
                MessageBox.Show("Preencher Campo Dosagem");
                cbDosagem.Focus();
            }
           
            else
            {
               DateTime DataAtual = DateTime.Now;

                DateTime validacaoData = DateTime.Parse(dtpValidacao.Text);

                int resultado = DateTime.Compare(validacaoData, DataAtual);

                if (resultado < 0)
                {
                    MessageBox.Show("Data de Validade menor ou igual a Data de Hoje!!!");
                    dtpValidacao.Focus();
                }
                else
                {
                    ValidacaoCadastroDuplicado();
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            
            var formPrincipal = new Form1(controlePerfilCadastro,usuarioCorrente);
            if (controlePerfilCadastro.Equals("Usuario"))
            {
                formPrincipal.Visible = true;
                formPrincipal.cadastroDeUsuáriosToolStripMenuItem.Enabled = false;
                formPrincipal.cadastroDeProdutosToolStripMenuItem.Enabled = false;
            }
            else if (controlePerfilCadastro.Equals("Operador"))
            {
                formPrincipal.Visible = true;
                formPrincipal.cadastroDeUsuáriosToolStripMenuItem.Enabled = false;
            }
            else if(controlePerfilCadastro.Equals("Administrador"))
            {
                formPrincipal.Visible = true;
            }
        }

       //private void txtDataFabricacao_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
       // {
       //     ToolTip toolTip = new ToolTip();

       //     if (!e.IsValidInput)
       //     {
       //         toolTip.ToolTipTitle = "Data Inválida";
       //         toolTip.Show("A Data deve ter um formato mm/yyyy.", dtpFabricacao, 0, -20, 1000);
               
                
       //     }
       //     else
       //     {
       //         //Now that the type has passed basic type validation, enforce more specific type rules.
       //         DateTime userDate = (DateTime)e.ReturnValue;
       //         if (userDate > DateTime.Now)
       //         {
       //             toolTip.ToolTipTitle = "Data Inválida";
       //             toolTip.Show("A data desse campo não deve ser menor que a data atual.", dtpValidacao, 0, -20, 5000);
       //             e.Cancel = true;
       //         }
       //     }
       // }

        //private void txtDataValidade_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        //{
        //    ToolTip toolTip = new ToolTip();

        //    if (!e.IsValidInput)
        //    {
        //        toolTip.ToolTipTitle = "Invalid Date";
        //        toolTip.Show("A Data deve ter um formato mm/yyyy.", dtpValidacao, 0, -20, 5000);
        //    }
        //    else
        //    {
        //        //Now that the type has passed basic type validation, enforce more specific type rules.
        //        DateTime userDate = (DateTime)e.ReturnValue;
        //        if (userDate < DateTime.Now)
        //        {
        //            toolTip.ToolTipTitle = "Invalid Date";
        //            toolTip.Show("A data desse campo não deve ser menor que a data atual.", dtpValidacao, 0, -20, 5000);
        //            e.Cancel = true;
        //        }
        //    }
        //}

       
       
    }
}
