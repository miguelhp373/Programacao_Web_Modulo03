using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using TransporteExecutivo.Models;

namespace TransporteExecutivo.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReceberCadastro([FromForm] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                string conteudo = string.Format("Dados do Usuário de Transporte \n" +
                                                "Nome: {0},\n" +
                                                "Telefone: {1}, \n" +
                                                "Ida: {2}, \n" +
                                                "Volta: {3}.",
                                                usuario.nome, usuario.telefone, usuario.ida, usuario.volta);

                return new ContentResult() { Content = conteudo };
            }
            else
            {
                return View("Index");
            }
        }
    }
}
