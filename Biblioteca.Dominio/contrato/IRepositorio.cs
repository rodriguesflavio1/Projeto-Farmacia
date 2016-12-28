using System.Collections.Generic;
using System.Data;


namespace Biblioteca.Dominio.contrato
{
    // contrato.                  Esse T representa qualquer classe que seja necessario receber
    public interface IRepositorio<T> where T : class
    {
       //assinatura do método, por isso nao tem chaves.
        void Salvar(T entidade);
        void Excluir(T entidade);
        void Alterar(T entidade);
        void AlterarQuantidade(T entidade);
        IEnumerable<T> ListarTodos();
       
       
         // onde T é o retorno do objeto que foi passado
        IEnumerable<T> ListarPorNome(string nome);
        DataTable ListarPaginacao(string nomeDaColuna, string nome);
        //DataTable ListarPaginacaoTeste(string nomeDaColuna, string nome, int regInicio, int quantidadeDeRegistrosPaginar);
       
    }

    public interface IRepositorioUsuario<C> where C : class
    {
             void SalvarUsuario(C entidade);
             void ExcluirUsuario(C entidade);
             void AlterarUsuario(C entidade);
             List<C> ListarPorNomeUsuario(string nome, string senha);

            IEnumerable<C> ListarTodosUsuarios();

    }

    public interface IRepositorioProdutoRelatorio<D> where D : class
    {
        void InserirProdutoRelatorio(D entidade);

    }
}
