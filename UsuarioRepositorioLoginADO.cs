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
    public class UsuarioRepositorioLoginADO : IRepositorioUsuario<Usuario>
    {

        private Contexto contexto;
        
        public void InserirUsuario(Usuario usuario)
        {
            var strQuery = "";
            strQuery += " insert into Usuario(usuarioNome,senha,perfil)";
            strQuery += string.Format(" values ('{0}','{1}','{2}') ", usuario.nomeUsuario, usuario.senha, usuario.perfil);


            // cria o objeto e assim que termina ele destroe
            using (contexto = new Contexto())
            {
                contexto.ExecutarComando(strQuery);
            }

        }

        public void SalvarUsuario(Usuario usuario)
        {
            if (usuario.usuarioId > 0)
            {
                AlterarUsuario(usuario);
            }
            else
            {
                InserirUsuario(usuario);
            }
        }

        public void AlterarUsuario(Usuario usuario)
        {
            var strQuery = "";
            strQuery += "update Usuario set";
            strQuery += string.Format(" usuarioNome =  '{0}', ", usuario.nomeUsuario);
            strQuery += string.Format(" senha =  '{0}' ,", usuario.senha);
            strQuery += string.Format(" perfil =  '{0}' ", usuario.perfil);
            strQuery += string.Format(" WHERE usuarioId =  '{0}' ", usuario.usuarioId);


            // cria o objeto e assim que termina ele destroe
            using (contexto = new Contexto())
            {
                contexto.ExecutarComando(strQuery);
            }

        }

        public void ExcluirUsuario(Usuario usuario)
        {
            using (contexto = new Contexto())
            {
                string strQuery = string.Format("delete from Usuario where usuarioId = {0}", usuario.usuarioId);
                contexto.ExecutarComando(strQuery);
            }
        }

        public IEnumerable<Usuario> ListarTodosUsuarios()
        {
            using (contexto = new Contexto())
            {
                var strQuery = "Select * from Usuario";
                var retornoDatareader = contexto.ExecutarComandoComRetorno(strQuery);
                return TransformaReaderEmListaDeObjetosUsuario(retornoDatareader);
            }
        }

        public List<Usuario> ListarPorNomeUsuario(string login,string senha)
        {
            using (contexto = new Contexto())
            {
                var strQuery = string.Format("SELECT * FROM [Farmacia].[dbo].[Usuario] where Usuarionome ='{0}' and senha = '{1}'", login,senha);
                var retornoDatareader = contexto.ExecutarComandoComRetorno(strQuery);
                return TransformaReaderEmListaDeObjetosUsuario(retornoDatareader);
            }
        }

        private List<Usuario> TransformaReaderEmListaDeObjetosUsuario(SqlDataReader reader)
        {
            var usuario = new List<Usuario>();

            while (reader.Read())
            {
                var ObjetoTemporario = new Usuario
                {
                    usuarioId = int.Parse(reader["usuarioId"].ToString()),
                    nomeUsuario = reader["usuarioNome"].ToString(),
                    senha = reader["senha"].ToString(),
                    perfil = reader["perfil"].ToString(),

                };

                usuario.Add(ObjetoTemporario);
            }
            reader.Close();
            return usuario;
        }
    }
}
