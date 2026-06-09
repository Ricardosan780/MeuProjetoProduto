using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MeuProjetoProduto.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            // Criando a lista de nomes
            List<string> produtos = new List<string> { "Teclado Mecânico", "Mouse Gamer", "Monitor 24'", "Fone de Ouvido", "Mousepad XL" };
            
            // Criando a lista de preços correspondentes
            List<double> precos = new List<double> { 250.00, 89.90, 899.00, 150.00, 45.00 };

            // Passando ambas as listas via ViewBag
            ViewBag.Nomes = produtos;
            ViewBag.Precos = precos;

            return View();
        }
    }
}