using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Dominio;
using Biblioteca.Dominio.contrato;

namespace Biblioteca.RepositorioADO
{
    public class ProdutoRepositorioRelatorioADO : IRepositorioProdutoRelatorio<ProdutoRelatorio>
    {
        private Contexto contexto;
        
        public void InserirProdutoRelatorio(ProdutoRelatorio produtoRelatorio)
        {
            var strQuery = "";
            strQuery += " insert into ProdutoRelatorio(nome,principioAtivo,quantidade,data)";
            strQuery += string.Format(" values ('{0}','{1}','{2}','{3}') ", produtoRelatorio.nome, produtoRelatorio.principioAtivo,
                produtoRelatorio.quantidade, produtoRelatorio.dataRetirada);


            // cria o objeto e assim que termina ele destroe
            using (contexto = new Contexto())
            {
                contexto.ExecutarComando(strQuery);
            }

        }
    }
}
