using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Dominio
{
    public class Produto
    {
       
        public int produtoId { get; set; }
        [DisplayName("Nome do Medicamento")]
        public string nome { get; set; }
        [DisplayName("Principio Ativo")]
        public string principioAtivo { get; set; }
        [DisplayName("Fabricante")]
        public string fabricante { get; set; }

        [DisplayFormat(DataFormatString = "mm/yyyy")]
        [DisplayName("Data de Validade")]
        public DateTime dataValidade { get; set; }
        [DisplayName("Apresentação")]
        public string apresentacao { get; set; }
        [DisplayName("Quantidade")]
        public int quantidade { get; set; }

        [DisplayFormat(DataFormatString = "mm/yyyy")]
        [DisplayName("Data de Fabricação")]
        public DateTime dataFabricacao { get; set; }

        [DisplayName("Código de Barras")]
        public string codigoBarras { get; set; }

        [DisplayName("Classe Terapêutica")]
        public string classeTerapeutica { get; set; }

        [DisplayName("Dosagem")]
        public string dosagem { get; set; }
        
        [DisplayName("Estoque Minimo")]
        public int estoqueMinimo { get; set; }
    }
}
