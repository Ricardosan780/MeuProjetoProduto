using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace MeuProjetoProduto.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Nova Action do Boletim
        public IActionResult Boletim()
        {
            // Criando a lista de Disciplinas
            List<string> disciplinas = new List<string> { "Matemática", "Português", "História", "Física", "Química" };
            
            // Criando a lista de Notas correspondentes
            List<double> notas = new List<double> { 9.5, 6.2, 8.0, 4.5, 7.0 };

            // Passando ambas as listas via ViewBag
            ViewBag.Disciplinas = disciplinas;
            ViewBag.Notas = notas;

            return View();
        }
    }
}