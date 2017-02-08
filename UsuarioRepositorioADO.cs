using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using Biblioteca.Dominio;
using Biblioteca.Dominio.contrato;


namespace Biblioteca.RepositorioADO
{
    public class UsuarioRepositorioADO : IRepositorio<Produto> 
    {
        private Contexto contexto;

        public void Inserir(Produto produto)
        {
            var strQuery = "";
            strQuery += " insert into Produto(nome,principioAtivo,apresentacao,fabricante,dataValidade,dataFabricacao,quantidade,codigoBarras,dosagem,classeTerapeutica,estoqueMinimo)";
            strQuery += string.Format(" values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}') ", produto.nome, produto.principioAtivo,
                produto.apresentacao,produto.fabricante,produto.dataValidade, produto.dataFabricacao,produto.quantidade,produto.codigoBarras,produto.dosagem,produto.classeTerapeutica,produto.estoqueMinimo);


            // cria o objeto e assim que termina ele destroe
            using (contexto = new Contexto())
            {
                contexto.ExecutarComando(strQuery);
            }

        }

      

        public void Alterar(Produto produto)
        {
            var strQuery = "";
            strQuery += "update Produto set";
            strQuery += string.Format(" nome =  '{0}', ", produto.nome);
            strQuery += string.Format(" principioativo =  '{0}' ,", produto.principioAtivo);
            strQuery += string.Format(" apresentacao =  '{0}' ,", produto.apresentacao);
            strQuery += string.Format(" fabricante =  '{0}' ,", produto.fabricante);
            strQuery += string.Format(" datavalidade =  '{0}' ,", produto.dataValidade);
            strQuery += string.Format(" datafabricacao =  '{0}', ", produto.dataFabricacao);
            strQuery += string.Format(" quantidade =  '{0}', ", produto.quantidade);
            strQuery += string.Format(" codigoBarras =  '{0}', ", produto.codigoBarras);
            strQuery += string.Format(" dosagem =  '{0}', ", produto.dosagem);
            strQuery += string.Format(" classeTerapeutica =  '{0}', ", produto.classeTerapeutica);
            strQuery += string.Format(" estoqueMinimo =  '{0}' ", produto.estoqueMinimo);
            strQuery += string.Format(" WHERE produtoId =  '{0}' ", produto.produtoId);

           
            // cria o objeto e assim que termina ele destroe
            using (contexto = new Contexto())
            {
                contexto.ExecutarComando(strQuery);
            }

        }

        public void AlterarQuantidade(Produto produto)
        {
            var strQuery = "";
            strQuery += "update Produto set";
            strQuery += string.Format(" quantidade =  '{0}' ", produto.quantidade);
            strQuery += string.Format(" WHERE produtoId =  '{0}' ", produto.produtoId);


            // cria o objeto e assim que termina ele destroe
            using (contexto = new Contexto())
            {
                contexto.ExecutarComando(strQuery);
            }

        }

        public void Salvar(Produto produto)
        {
            if (produto.produtoId > 0)
            {
                Alterar(produto);
            }
            else
            {
                Inserir(produto);
            }
        }

        public void Excluir(Produto produto)
        {
            using (contexto = new Contexto())
            {
                string strQuery = string.Format("delete from Produto where produtoId = {0}", produto.produtoId);
                contexto.ExecutarComando(strQuery);
            }
        }

        public IEnumerable<Produto> ListarTodos()
        {
            using (contexto = new Contexto())
            {
                var strQuery = "Select * from Produto";
                var retornoDatareader = contexto.ExecutarComandoComRetorno(strQuery);
                return TransformaReaderEmListaDeObjetos(retornoDatareader);
            }
        }

        public IEnumerable<Produto> ListarPorNome(string nome)
        {
            using (contexto = new Contexto())
            {
                var strQuery = string.Format("SELECT produtoId,nome,principioAtivo,apresentacao,fabricante,dataValidade,dataFabricacao,quantidade,codigoBarras,dosagem,classeTerapeutica FROM [Farmacia].[dbo].[Produto] where nome like '{0}%'", nome);
                var retornoDatareader = contexto.ExecutarComandoComRetorno(strQuery);
                return TransformaReaderEmListaDeObjetos(retornoDatareader);
            }
        }

        //transforma um datareader numa lista de alunos
        private List<Produto> TransformaReaderEmListaDeObjetos(SqlDataReader reader)
        {
            var produtos = new List<Produto>();

            while (reader.Read())
            {
                var ObjetoTemporario = new Produto
                {
                    produtoId = int.Parse(reader["produtoId"].ToString()),
                    nome      = reader["nome"].ToString(),
                    principioAtivo       = reader["principioAtivo"].ToString(),
                    apresentacao = reader["apresentacao"].ToString(),
                    fabricante = reader["fabricante"].ToString(),
                    dataValidade = Convert.ToDateTime( reader["dataValidade"].ToString()),
                    dataFabricacao = Convert.ToDateTime(reader["dataFabricacao"].ToString()),
                    quantidade   = Convert.ToInt32(reader["quantidade"].ToString()),
                    codigoBarras = reader["codigoBarras"].ToString(),
                    dosagem = reader["dosagem"].ToString(),
                    classeTerapeutica = reader["classeTerapeutica"].ToString(),
                    estoqueMinimo = int.Parse(reader["estoqueMinimo"].ToString()),

                };

                produtos.Add(ObjetoTemporario);
            }
            reader.Close();
            return produtos;
        }
            

        public DataTable ListarPaginacao(string nomeDaColuna,string nomeObjeto)
        {
            using (contexto = new Contexto())
            {
                var strQuery = ""; 
                strQuery += string.Format("SELECT produtoId,nome,principioAtivo,apresentacao,fabricante,dataValidade,dataFabricacao,quantidade,codigoBarras,dosagem,classeTerapeutica FROM [Farmacia].[dbo].[Produto] where") ;
                strQuery += string.Format(" "+"{0}", nomeDaColuna);
                strQuery += string.Format(" "+"like '{0}%'",nomeObjeto);
                var retornoDataSet = contexto.ExecutarComandoDatasetComRetorno(strQuery);
                
                return retornoDataSet;
            }
        }
                  
        //public static string  strQuery1 = "";
        //public DataTable ListarPaginacaoTeste(string nomeDaColuna, string nomeObjeto, int regInicio, int quantidadeDeRegistrosPaginar)
        //{
        //    using (contexto = new Contexto())
        //    {
                
        //        strQuery1 += string.Format("SELECT produtoId,nome,principioAtivo,apresentacao,fabricante,dataValidade,dataFabricacao,quantidade,codigoBarras FROM [Farmacia].[dbo].[Produto] where");
        //        strQuery1 += string.Format(" " + "{0}", nomeDaColuna);
        //        strQuery1 += string.Format(" " + "like '{0}%'", nomeObjeto);
        //        var retornoDataSet = contexto.ExecutarComandoDatasetComRetornoTeste(strQuery1,regInicio,quantidadeDeRegistrosPaginar);

        //        return retornoDataSet;
        //    }


        //}

        //public static string resultado()
        //{
        //    string resultado = strQuery1;
        //    return resultado;
        //}


        //public void InserirUsuario(Usuario usuario)
        //{
        //    var strQuery = "";
        //    strQuery += " insert into Usuario(usuarioNome,senha,perfil)";
        //    strQuery += string.Format(" values ('{0}','{1}','{2}') ", usuario.nomeUsuario, usuario.senha, usuario.perfil);


        //    // cria o objeto e assim que termina ele destroe
        //    using (contexto = new Contexto())
        //    {
        //        contexto.ExecutarComando(strQuery);
        //    }

        //}

        //public void SalvarUsuario(Usuario usuario)
        //{
        //    if (usuario.usuarioId > 0)
        //    {
        //        AlterarUsuario(usuario);
        //    }
        //    else
        //    {
        //        InserirUsuario(usuario);
        //    }
        //}

        //public void AlterarUsuario(Usuario usuario)
        //{
        //    var strQuery = "";
        //    strQuery += "update Produto set";
        //    strQuery += string.Format(" usuarioNome =  '{0}', ", usuario.nomeUsuario);
        //    strQuery += string.Format(" senha =  '{0}' ,", usuario.senha);
        //    strQuery += string.Format(" perfil =  '{0}' ", usuario.perfil);
        //    strQuery += string.Format(" WHERE usuarioId =  '{0}' ", usuario.usuarioId);


        //    // cria o objeto e assim que termina ele destroe
        //    using (contexto = new Contexto())
        //    {
        //        contexto.ExecutarComando(strQuery);
        //    }

        //}

        //public void ExcluirUsuario(Usuario usuario)
        //{
        //    using (contexto = new Contexto())
        //    {
        //        string strQuery = string.Format("delete from Usuario where usuarioId = {0}", usuario.usuarioId);
        //        contexto.ExecutarComando(strQuery);
        //    }
        //}

        //public IEnumerable<Usuario> ListarTodosUsuarios()
        //{
        //    using (contexto = new Contexto())
        //    {
        //        var strQuery = "Select * from Usuario";
        //        var retornoDatareader = contexto.ExecutarComandoComRetorno(strQuery);
        //        return TransformaReaderEmListaDeObjetosUsuario(retornoDatareader);
        //    }
        //}

        //private List<Usuario> TransformaReaderEmListaDeObjetosUsuario(SqlDataReader reader)
        //{
        //    var usuarios = new List<Usuario>();

        //    while (reader.Read())
        //    {
        //        var ObjetoTemporario = new Usuario
        //        {
        //            usuarioId = int.Parse(reader["usuarioId"].ToString()),
        //            nomeUsuario = reader["nomeUsuario"].ToString(),
        //            perfil = reader["perfil"].ToString(),

        //        };

        //        usuario.Add(ObjetoTemporario);
        //    }
        //    reader.Close();
        //    return usuarios;
        //}

      
        
    }
}
