using Microsoft.VisualBasic;

namespace ApiEstoque.Models;

public class Categoria
{
    //public Categoria()
    //{
    //    Produtos = new Collection<Produto>();
    //}
    [Key]
    public int CategoriaId { get; set; }
    [StringLength(50)]
    [Required(ErrorMessage = "Campo obrigatório")]
    public string? Nome { get; set; }
    [StringLength(100)]
    [Required(ErrorMessage = "Campo obrigatório")]
    public string? ImagemUrl { get; set; }

    public ICollection<Produto> Produtos { get; set; }
}
