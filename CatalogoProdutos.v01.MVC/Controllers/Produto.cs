using CatalogoProdutos.v01.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CatalogoProdutos.v01.MVC.Controllers
{
    public class ProdutoController: Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            // Exibe o formulário para cadastrar o produto.
            return View();
        }

        [HttpPost]
        public ActionResult Create(Produto produto)
        {
            // Se os dados informados forem válidos, definir uma mensagem temporária de sucesso e 
            if (ModelState.IsValid)
            {
                TempData["Mensagem"] = "Produto cadastrado com sucesso!";
                return RedirectToAction("Create");
            }

            return View(produto);
        }


    }
}
