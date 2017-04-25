using System;
using System.Collections.Generic;
using System.Data;
using System.Security.AccessControl;
using System.Text.RegularExpressions;
using Biblioteca.Dominio;
using Biblioteca.Dominio.contrato;

namespace Biblioteca.Aplicacao
{
    public class UsuarioAplicacao
    {
       
        
                
            
        private readonly IRepositorio<Produto> repositorio;
        private readonly IRepositorioUsuario<Usuario> repositorioUsuario;
        private readonly IRepositorioProdutoRelatorio<ProdutoRelatorio> repositorioProdutoRelatorio;
        
       //metodo construtor

         public UsuarioAplicacao() { }

        public UsuarioAplicacao(IRepositorio<Produto> repositorioProduto)
        {
            
            repositorio = repositorioProduto;
        }
        
        public UsuarioAplicacao(IRepositorioUsuario<Usuario> repositoUsuario)
        {
            repositorioUsuario = repositoUsuario;
        }

        public UsuarioAplicacao(IRepositorioProdutoRelatorio<ProdutoRelatorio> repositorioProdutoRel)
        {
            repositorioProdutoRelatorio = repositorioProdutoRel;
        }



        public void Salvar(Produto produto)
        {
           repositorio.Salvar(produto);
        }

        public void Excluir(Produto produto)
        {
            repositorio.Excluir(produto);
        }

        public void Alterar(Produto produto)
        {
            repositorio.Alterar(produto);
        }

        public void AlterarQuantidade(Produto produto)
        {
            repositorio.AlterarQuantidade(produto);
        }

        public IEnumerable<Produto> ListarTodos()
        {
            return repositorio.ListarTodos();
        }

        public IEnumerable<Produto> ListarPorNome(string nome)
        {
            return repositorio.ListarPorNome(nome);
        }

        public void InserirProdutoRelatorio(ProdutoRelatorio produtoRelatorio) 
        {
            // como é uma inserção nao precisa retorno
            repositorioProdutoRelatorio.InserirProdutoRelatorio(produtoRelatorio);
        }

       
        
        
        /* Métodos apenas relativos a o usuario */
        public void SalvarUsuario(Usuario usuario)
        {
            
            repositorioUsuario.SalvarUsuario(usuario);
        }

      

        public void AlterarUsuario(Usuario usuario)
        {
            repositorioUsuario.AlterarUsuario(usuario);
        }

        public void ExcluirUsuario(Usuario usuario) 
        {
            repositorioUsuario.ExcluirUsuario(usuario);
        }

        public IEnumerable<Usuario> ListarTodosUsuarios()
        {
            return repositorioUsuario.ListarTodosUsuarios();
        }
        public List<Usuario> ListarPorNomeUsuario(string nome, string senha) 
        {
            return repositorioUsuario.ListarPorNomeUsuario(nome, senha);
        }

      

        //public int ListarPorQuantidadeDeRegistro()
        //{
        //    return repositorio.ListarQuantidadeDeRegistros();
        //}

        public DataTable ListarPorNomePaginando(string nomeDaColuna, string nome)
        {
            return repositorio.ListarPaginacao(nomeDaColuna,nome);
        }

        public string RemoverCaracteresEspeciais(string valor)
        {
            Regex r = new Regex("(?:[^a-z0-9 ]|(?<=['\"])s)", RegexOptions.IgnoreCase | RegexOptions.CultureInvariant | RegexOptions.Compiled);
            return r.Replace(valor, String.Empty);
        }

        public string RemoverAcentos(string valor)
        {
            valor = Regex.Replace(valor, "[ÁÀÂÃ]", "A");
            valor = Regex.Replace(valor, "[ÉÈÊ]", "E");
            valor = Regex.Replace(valor, "[ÍÌÎ]", "I");
            valor = Regex.Replace(valor, "[ÓÒÔÕ]", "O");
            valor = Regex.Replace(valor, "[ÚÙÛÜ]", "U");
            valor = Regex.Replace(valor, "[Ç]", "C");
            valor = Regex.Replace(valor, "[áàâã]", "A");
            valor = Regex.Replace(valor, "[éèê]", "E");
            valor = Regex.Replace(valor, "[íìî]", "I");
            valor = Regex.Replace(valor, "[óòôõ]", "O");
            valor = Regex.Replace(valor, "[úùûü]", "U");
            valor = Regex.Replace(valor, "[ç]", "C");
            return valor;
        }

        

        //public int RetornaQuantidadeDeRegistros()
        //{
        //    return repositorio.ListarQuantidadeDeRegistros();
        //}

        //public DataTable ListarPorNomePaginandoTeste(string nomeDaColuna, string nome, int regInicio, int quantidadeDeRegistrosPaginar)
        //{
        //    return repositorio.ListarPaginacaoTeste(nomeDaColuna, nome,regInicio,quantidadeDeRegistrosPaginar);
        //}
        
       
    }
    
    
   
}
