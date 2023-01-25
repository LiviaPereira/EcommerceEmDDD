using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Site.Controllers
{
    public class LoginCadastro : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Cadastro()
        {
            return View();
        }

    }
}
