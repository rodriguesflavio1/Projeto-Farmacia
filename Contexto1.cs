using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;

namespace Biblioteca.RepositorioADO
{
    public class Contexto : IDisposable
    {

        private  readonly SqlConnection minhaConexao = null;

        //Conexao com o banco de dados
        public Contexto()
        {
            //instrução que recebe a conectionstring e realiza a conexao com o banco
            minhaConexao = new SqlConnection(ConfigurationManager.ConnectionStrings["stringConexao"].ConnectionString);
            minhaConexao.Open();
            

        }

        //Executa comando insert, delete, update. comando sem retorno
        public void ExecutarComando(string Query)
        {
            var cmd = new SqlCommand
            {
                CommandText = Query,
                CommandType = CommandType.Text,
                Connection = minhaConexao
            };

            cmd.ExecuteNonQuery();
        }

        public SqlDataReader ExecutarComandoComRetorno(string Query)
        {
            var cmdComando = new SqlCommand(Query, minhaConexao);
            return cmdComando.ExecuteReader();
        }

       

        
        //SqlDataAdapter pagingAdapter = new SqlDataAdapter(UsuarioRepositorioADO.strQuery1,minhaConexao);
       
        public DataTable ExecutarComandoDatasetComRetorno(string Query)
        {

            DataTable paginaDS = new DataTable();
            //int regInicio = 0;
            //int quantidadeDeRegistrosPaginar = 2;
            //int TotalRegistros = RetornaQuantidadeDeRegistros("Select Count(*) from Produto");

            try
            {
                
                SqlDataAdapter pagingAdapter = new SqlDataAdapter(Query,minhaConexao);
                pagingAdapter.Fill(paginaDS);
                
               
            }
            catch (Exception ex)
            {

               throw;
            }
            //retornando dataset preenchido
           return paginaDS;
        }

        
        //public DataTable ExecutarComandoDatasetComRetornoTeste(string Query,int regInicio,int quantidadeDeRegistrosPaginar)
        //{

           
        //    int TotalRegistros = RetornaQuantidadeDeRegistros("Select Count(*) from Produto");

        //    try
        //    {

        //        regInicio = regInicio - 5;
        //        if (regInicio > 0)
        //        {
        //            regInicio = 0;
        //        }
        //        paginaDS.Clear();
        //        //SqlDataAdapter pagingAdapter = new SqlDataAdapter(Query, minhaConexao);
        //        pagingAdapter.Fill(regInicio, quantidadeDeRegistrosPaginar, paginaDS);


        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }
        //    //retornando dataset preenchido
        //    return paginaDS;
        //}


        // abre a conexao com o banco e fecha novamente
       
        public void Dispose()
        {
            if (minhaConexao.State == ConnectionState.Open)
            {
                minhaConexao.Close();
            }
        }

        //comando vai me retorna a quantidade de registro do banco
        public  int RetornaQuantidadeDeRegistros(string QueryQuantidade)
        {
            

            using (SqlCommand command = new SqlCommand(QueryQuantidade, minhaConexao))
                {
                    return Convert.ToInt32(command.ExecuteScalar());
                }
           
        }


        
    }
}
