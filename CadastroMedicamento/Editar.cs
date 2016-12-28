using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Dominio;
using Biblioteca.Aplicacao;

namespace CadastroMedicamento
{
    public partial class Editar : Form
    {
        public Editar()
        {
            InitializeComponent();
        }

        Produto objetoTeste = new Produto();
        private int produtoId;

        //Carrega os textbox vindo do datagridview do form de pesquisa
        public Editar(Produto objetoProduto)
        {
            InitializeComponent();
            produtoId = objetoProduto.produtoId;
            txtNome.Text = objetoProduto.nome;
            txtApresentacao.Text = objetoProduto.apresentacao;
            txtFabricante.Text = objetoProduto.fabricante;
            txtPrincipioAtivo.Text = objetoProduto.principioAtivo;
            txtQuantidade.Text = Convert.ToString(objetoProduto.quantidade);
            dtpFabricacao.Text = Convert.ToString(objetoProduto.dataFabricacao.Date);
            dtpValidade.Text = Convert.ToString(objetoProduto.dataValidade);
            mktCodigoBarras.Text = objetoProduto.codigoBarras;
            cbDosagem.Text = objetoProduto.dosagem;
            cbClasseTerapeutica.Text = objetoProduto.classeTerapeutica;
            mkEstoqueMinimo.Text = Convert.ToString(objetoProduto.estoqueMinimo);


        }


        private void btnAlterar_Click(object sender, EventArgs e)
        {
            ValidacaoCamposBrancos();
        }

        private void AlterarProduto()
        {
            var produtoApp = UsuarioAplicacaoConstrutor.UsuarioAplicacaoADO();

                objetoTeste.nome = produtoApp.RemoverCaracteresEspeciais(txtNome.Text.ToUpper());
                objetoTeste.apresentacao = produtoApp.RemoverCaracteresEspeciais(txtApresentacao.Text.ToUpper());
                objetoTeste.fabricante = produtoApp.RemoverCaracteresEspeciais(txtFabricante.Text.ToUpper());
                objetoTeste.principioAtivo = produtoApp.RemoverCaracteresEspeciais(txtPrincipioAtivo.Text.ToUpper());
                objetoTeste.quantidade = Convert.ToInt32(txtQuantidade.Text);
                objetoTeste.dataFabricacao = Convert.ToDateTime(dtpFabricacao.Text);
                objetoTeste.dataValidade = Convert.ToDateTime(dtpValidade.Text);
                objetoTeste.codigoBarras = mktCodigoBarras.Text;
                objetoTeste.produtoId = produtoId;
                objetoTeste.dosagem = produtoApp.RemoverCaracteresEspeciais(cbDosagem.Text);
                objetoTeste.classeTerapeutica = produtoApp.RemoverCaracteresEspeciais(cbClasseTerapeutica.Text);
                objetoTeste.estoqueMinimo = Convert.ToInt32(mkEstoqueMinimo.Text);

                produtoApp.Salvar(objetoTeste);
            MessageBox.Show("Produto Alterado com Sucesso");
            this.Close();
            Pesquisar p = new Pesquisar();
            object sender = null;
            EventArgs e = null;
            p.PesquisarPadrao(sender, e);

        }

        //Método Limpar campos
        private void LimparCampos(Control PanelID)
        {
            foreach (Control item in PanelID.Controls)
            {
                if (item is TextBox)
                {
                    TextBox questionTextBox = item as TextBox;
                    if (questionTextBox != null)
                    {
                        questionTextBox.Text = "";
                    }
                }
                if (item is MaskedTextBox)
                {

                    MaskedTextBox questionTextBox = item as MaskedTextBox;
                    if (questionTextBox != null)
                    {
                        questionTextBox.Text = "";
                    }
                }
                if (item is ComboBox)
                {

                    ComboBox questionTextBox = item as ComboBox;
                    if (questionTextBox != null)
                    {
                        questionTextBox.Text = "";
                    }
                }

                if (item.Controls.Count > 0)
                {
                    LimparCampos(item);
                }
            }
        }

        //Verifica se todos os campos foram preenchidos
        private void ValidacaoCamposBrancos()
        {
            if (String.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Preencher Campo Nome");
                txtNome.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtFabricante.Text))
            {
                MessageBox.Show("Preencher Campo com o Nome do Fabricante");
                txtFabricante.Focus();
            }

            else if (String.IsNullOrWhiteSpace(txtApresentacao.Text))
            {
                MessageBox.Show("Preencher Campo com a Apresentação do Medicamento");
                txtApresentacao.Focus();
            }
            else if (String.IsNullOrWhiteSpace(txtPrincipioAtivo.Text))
            {
                MessageBox.Show("Preencher Campo Nome do Principio Ativo");
                txtPrincipioAtivo.Focus();
            }
            else if (String.IsNullOrWhiteSpace(mktCodigoBarras.Text))
            {
                MessageBox.Show("Preencher Campo com Código de Barras");
                mktCodigoBarras.Focus();
            }
            else if (String.IsNullOrWhiteSpace(dtpValidade.Text))
            {
                MessageBox.Show("Preencher Campo com a Data de Validade");
                dtpValidade.Focus();
            }
            else if (String.IsNullOrWhiteSpace(dtpFabricacao.Text))
            {
                MessageBox.Show("Preencher Campo com a Data de Fabricação");
                dtpValidade.Focus();
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
                AlterarProduto();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos(this);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Form formPesq = new Pesquisar();
            formPesq.Show();
            
            this.Close();

        }
    }
}
