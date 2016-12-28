using System.Web.Mvc;
using Biblioteca.Aplicacao;
using Biblioteca.Dominio;

namespace Biblioteca.UI.Web.Razor.Controllers
{
    public class HomeController : Controller
    {

        private readonly UsuarioAplicacao appUsuario;

        public HomeController()
        {
            // aqui eu posso mudar o tipo de repositorio que eu desejar, seja o ADO ou Entity
            appUsuario = UsuarioAplicacaoConstrutor.UsuarioAplicacaoADO();
        }

        public ActionResult Index()
        {
            //var appUsuario = UsuarioAplicacaoConstrutor.UsuarioAplicacaoADO();
            var listaUsuario = appUsuario.ListarTodos();
            
            return View(listaUsuario);
        }

        // Esse método cria a pagina de cadastro
        public ActionResult Cadastrar()
        {
            
            return View();
        }


        [HttpPost]// vai enviar via post
       // [ValidateAntiForgeryToken]// segurança quanto a acesso indesejado?
        public ActionResult Cadastrar(Produto usuario)
        {
            
            if (ModelState.IsValid)
            {
                //var appUsuario = UsuarioAplicacaoConstrutor.UsuarioAplicacaoADO();
                    appUsuario.Salvar(usuario);
                return RedirectToAction("Index");
            }
            else
            {
                return View(usuario);
            }

           
        }

        
        //Método somente exibe os dados do usario na tela
        public ActionResult Editar(string id)
        {
            //var appUsuario = UsuarioAplicacaoConstrutor.UsuarioAplicacaoADO(); 
            var usuario = appUsuario.ListarPorNome(id);

            if (id == null)
            
                return HttpNotFound();
           
            return View(usuario);
        }

        //Método efetivamente faz salva a alteração no banco de dados
        [HttpPost]
        public ActionResult Editar(Produto usuario)
        {
            if (ModelState.IsValid)
            {
                //var appUsuario = UsuarioAplicacaoConstrutor.UsuarioAplicacaoADO(); 
                appUsuario.Salvar(usuario);
                return RedirectToAction("Index");
            }
            else
            {
                return View(usuario);
            }
        }


        public ActionResult Detalhes(string id)
        {
            //var appUsuario = UsuarioAplicacaoConstrutor.UsuarioAplicacaoADO(); 
            var usuario = appUsuario.ListarPorNome(id);

            if (id == null)

                return HttpNotFound();

            return View(usuario);
        }

        public ActionResult Excluir(string id)
        {
            //var appUsuario = UsuarioAplicacaoConstrutor.UsuarioAplicacaoADO(); 
            var usuario = appUsuario.ListarPorNome(id);

            if (id == null)

                return HttpNotFound();

            return View(usuario);
        }


        [HttpPost,ActionName("Excluir")]
   
        public ActionResult ExcluirConfirmado(string id)
        {
            //var appUsuario = UsuarioAplicacaoConstrutor.UsuarioAplicacaoADO();
            //var usuarioTemp = appUsuario.ListarPorId(id);
            //appUsuario.Excluir(usuarioTemp);
            return RedirectToAction("Index");
        }
    }
}
