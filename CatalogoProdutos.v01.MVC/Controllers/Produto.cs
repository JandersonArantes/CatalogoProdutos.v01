using CatalogoProdutos.v01.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CatalogoProdutos.v01.MVC.Controllers {
    public class ProdutoController : Controller {
        // GET: Produto/Create
        [HttpGet]
        public ActionResult Create() {
            // Exibe o formulário para cadastrar o produto.
            return View();
        }

        // POST: Produto/Create
        [HttpPost]
        public ActionResult Create(Produto produto) {
            // Se os dados informados forem válidos, definir uma mensagem temporária de sucesso e 
            if (ModelState.IsValid) {
                TempData["Mensagem"] = "Produto cadastrado com sucesso!";
                return RedirectToAction("Create");
            }

            return View(produto);
        }

        // GET: Produto
        public ActionResult Index() {
            var produto = new List<Produto> {
                new Produto{Id=1, Nome="Mouse", Categoria = "Periféricos"},
                new Produto{Id=2, Nome="Teclado", Categoria = "Periféricos"},
                new Produto{Id=3, Nome="Monitor", Categoria = "Vídeos"}
            };

            return View(produto);
        }

    }
}
