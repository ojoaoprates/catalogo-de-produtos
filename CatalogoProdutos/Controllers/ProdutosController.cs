using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CatalogoProdutos.Models;

namespace CatalogoProdutos.Controllers
{
    public class ProdutosController : Controller
    {
        public IActionResult Index()
        {
            var produtos = new List<Product>
            {
                new Product { Id = 1, Nome = "Chocolate", Categoria = "chocolate", Preco = 4.50m, Descricao = "Barra 90g" },
                new Product { Id = 2, Nome = "Refrigerante", Categoria = "refrigerante", Preco = 3.00m, Descricao = "350ml, sabor cola" },
                new Product { Id = 3, Nome = "Salgadinho", Categoria = "salgadinho", Preco = 2.50m, Descricao = "Pacote 70g" },
                new Product { Id = 4, Nome = "Bolacha", Categoria = "bolacha", Preco = 3.20m, Descricao = "Pacote 120g" }
            };

            ViewBag.Produtos = produtos;
            ViewBag.Titulo = "Catálogo de Produtos";

            return View();
        }
    }
}