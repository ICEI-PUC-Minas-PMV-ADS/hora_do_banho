using HoraDoBanho.Domain.Models;
using HoraDoBanho.Domain.Services.Interfaces;
using HoraDoBanho.Models;
using Microsoft.AspNetCore.Mvc;

namespace HoraDoBanho.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginService _loginService;

        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel login)
        {
            LoginModel loginModel = new LoginModel() 
            { 
                UserName = login.UserName,
                Password = login.Password
            };
            Domain.Models.RetornoBase retorno = _loginService.ValidarLogin(loginModel).Result;

            login.Sucesso = retorno.Sucesso;
            login.Mensagem = retorno.MsgRetorno;

            return View("Index", login);
        }
    }
}
