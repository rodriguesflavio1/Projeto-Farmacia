using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace Biblioteca.Dominio
{
    public class ProdutoRelatorio
    {
        public int produtoId { get; set; }
        
        [DisplayName("Nome do Medicamento")]
        public string nome { get; set; }
       
        [DisplayName("Principio Ativo")]
        public string principioAtivo { get; set; }

        [DisplayFormat(DataFormatString = "mm/yyyy")]
        [DisplayName("Data de Validade")]
        public DateTime dataRetirada { get; set; }

        [DisplayName("Quantidade")]
        public int quantidade { get; set; }



       


    }
}
