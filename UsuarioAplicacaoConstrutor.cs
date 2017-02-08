using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.RepositorioADO;

namespace Biblioteca.Aplicacao
{
    public class UsuarioAplicacaoConstrutor
    {
        // método encapsula o método UsuarioRepositorioADO e passa ela como parametro
        public static UsuarioAplicacao UsuarioAplicacaoADO()
        {
            return new UsuarioAplicacao(new UsuarioRepositorioADO());
        }

        public static UsuarioAplicacao UsuarioAplicacaoUsuarioADO()
        {
            return new UsuarioAplicacao(new UsuarioRepositorioLoginADO());
        }

        public static UsuarioAplicacao UsuarioAplicacaoProdutoRelatorioADO()
        {
            return new UsuarioAplicacao(new ProdutoRepositorioRelatorioADO());
        }
       
    }
}
