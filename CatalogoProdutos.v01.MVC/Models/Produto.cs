using System.ComponentModel.DataAnnotations;

namespace CatalogoProdutos.v01.MVC.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O preço é obrigatório.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Informe um valor válido.")]
        public double Preco { get; set; }
    }
}
