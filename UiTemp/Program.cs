using System;
using System.Data.SqlClient;
using Biblioteca.Aplicacao;


namespace UiTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conexao = new SqlConnection(@"data source=ADILM-PC;Integrated Security= SSPI;Initial Catalog=Biblioteca Nosso Lar");
            
            conexao.Open();

            //var contexto = new Contexto();
            var usuarioApp = UsuarioAplicacaoConstrutor.UsuarioAplicacaoADO();
            
           
            //codigo faz atualização no banco de dados
            //string strqueryUpdate = "update Usuario set nome = 'Flavio Barbosa Rodrigues' where UsuarioId = 1";
            //SqlCommand comandoUpdate = new SqlCommand(strqueryUpdate,conexao);
            //comandoUpdate.ExecuteNonQuery();



            //codigo faz delete no banco de dados
            //string strqueryDelete = "delete from Usuario where UsuarioId = 3";
            //SqlCommand comandoDelete = new SqlCommand(strqueryDelete, conexao);
            //comandoDelete.ExecuteNonQuery();

             Console.WriteLine("Digite um nome");
             string _nome =  Console.ReadLine();

             Console.WriteLine("Digite o CPF");
             string _cpf = Console.ReadLine();

             Console.WriteLine("Digite a Data de Nascimento");
             string _dtNascimento = Console.ReadLine();
             
             Console.WriteLine("Digite o Endereço");
             string _endereco = Console.ReadLine();

             Console.WriteLine("Digite o Bairro");
             string _bairro = Console.ReadLine();

             Console.WriteLine("Digite a Cidade");
             string _cidade = Console.ReadLine();

            //var usuario1 = new Usuario
            //{
            //    nome = _nome,
            //    cpf = _cpf,
            //    dataNascimento = DateTime.Parse(_dtNascimento),
            //    endereco = _endereco,
            //    bairro = _bairro,
            //    cidade = _cidade
            //};

            //usuario.usuarioId = 1;

            //usuarioApp.Salvar(usuario1);

             //codigo faz delete no banco de dados
             //string strqueryInsert = string.Format("insert into Usuario(Nome,Cpf,DataNascimento,Endereco,Bairro,Cidade) values('{0}','{1}','{2}','{3}','{4}','{5}')",nome,cpf,dtNascimento,endereco,bairro,cidade);
             //SqlCommand comandoInsert = new SqlCommand(strqueryInsert, conexao);
             //comandoInsert.ExecuteNonQuery();

            

            //Código faz um select no banco de dados
            //string strquerySelect = "select * from Usuario";
           // SqlCommand comandoSelect = new SqlCommand(strquerySelect, conexao);
            //SqlDataReader dados = comandoSelect.ExecuteReader();// esecutereader serve apenas para o select

            //contexto.ExecutarComando(strqueryInsert);
            //SqlDataReader dados = contexto.ExecutarComandoComRetorno(strquerySelect);

            //while (dados.Read()) 
            //{
            //    Console.WriteLine("Id:{0}, Nome:{1}, Cpf:{2}, Data Nascimento:{3}, Endereço:{4},Bairro:{5}, Cidade:{6}", dados["UsuarioId"],dados["Nome"], dados["Cpf"], 
            //        dados["DataNascimento"],dados["Endereco"],dados["Bairro"],dados["Cidade"]);
                
            //}

            //var Dados = usuarioApp.ListarTodos();
            //foreach (var usuario in Dados)
            //{
            //    Console.WriteLine("Id:{0}, Nome:{1}, Cpf:{2}, Data Nascimento:{3}, Endereço:{4},Bairro:{5}, Cidade:{6}",usuario.usuarioId ,usuario.nome, usuario.cpf, 
            //       usuario.dataNascimento,usuario.endereco,usuario.bairro,usuario.cidade);
            //}
            //Console.ReadLine();



        }
    }
}
