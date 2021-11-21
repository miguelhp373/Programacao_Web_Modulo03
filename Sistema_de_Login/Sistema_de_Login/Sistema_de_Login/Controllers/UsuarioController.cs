using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Sistema_de_Login.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Sistema_de_Login.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            if(User.Identity.IsAuthenticated)
            {
                return RedirectToAction("UserPage");
            }

            return View();
        }

        [HttpPost, HttpGet]
        public IActionResult LoginPage(Usuario usuario)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    if(usuario.Login == "etecvav01" && usuario.Senha == "123456")
                    {
                        Login(usuario);
                        return RedirectToAction("UserPage");
                    }
                    else
                    {
                        ViewBag.Erro = "Usuario e/ou senha incorretos!";
                    }
                }
            }
            catch(Exception)
            {
                ViewBag.Erro = "Ocoreu um erro ao tender se logar, tente novamente!";
            }
            return View();
        }

        public async void Login(Usuario usuario)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, usuario.Login),
                new Claim(ClaimTypes.Role, "Usuario_Comum")
            };

            var indentidadeDeAutenticacao = new ClaimsIdentity(claims, "Login");
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(indentidadeDeAutenticacao);

            var propriedadeDeAutenticacao = new AuthenticationProperties
            {
                AllowRefresh = true,
                ExpiresUtc = DateTime.Now.ToLocalTime().AddMinutes(30),
                IsPersistent = true
            };

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                                          claimsPrincipal, propriedadeDeAutenticacao);

        }

        [Authorize]
        public IActionResult UserPage()
        {
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index");
        }
    }
}
