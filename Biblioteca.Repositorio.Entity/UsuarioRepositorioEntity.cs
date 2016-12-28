using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Dominio;
using Biblioteca.Dominio.contrato;

namespace Biblioteca.Repositorio.Entity
{
    public class UsuarioRepositorioEntity :IRepositorio<Produto>
    {
        public readonly Contexto contexto;

        public UsuarioRepositorioEntity()
        {
            contexto = new Contexto();
        }



        public void Salvar(Produto entidade)
        {
            if (entidade.produtoId > 0)
            {
                //codigo do entity para buscar um entidade no banco
                var alterarUsuario = contexto.Usuarios.First(x => x.produtoId == entidade.produtoId);

                alterarUsuario.nome = entidade.nome;
                alterarUsuario.fabricante = entidade.fabricante;
                alterarUsuario.dataValidade = entidade.dataValidade;
                alterarUsuario.apresentacao = entidade.apresentacao;
                
                alterarUsuario.principioAtivo = entidade.principioAtivo;
                alterarUsuario.apresentacao = entidade.apresentacao;
                alterarUsuario.quantidade = entidade.quantidade;
                alterarUsuario.codigoBarras = entidade.codigoBarras;
            }
            else
            {
                //método efetua a inserção do registro.
                contexto.Usuarios.Add(entidade);
            }

            //comita os comando acima no banco de dados
            contexto.SaveChanges();
        }

        public void Excluir(Produto entidade)
        {
            var ExcluirUsuario = contexto.Usuarios.First(x => x.produtoId == entidade.produtoId);
            contexto.Set<Produto>().Remove(ExcluirUsuario);
            contexto.SaveChanges();
        }

        public IEnumerable<Produto> ListarTodos()
        {
            return contexto.Usuarios;
        }

        public Produto ListarPorNome(string id)
        {
            int idTemp;
            //converte uma string em um inteiro
            Int32.TryParse(id, out idTemp);
            return contexto.Usuarios.First(x => x.produtoId == idTemp);
        }
    }
}
