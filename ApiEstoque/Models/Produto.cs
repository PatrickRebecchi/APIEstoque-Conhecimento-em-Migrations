

namespace ApiEstoque.Models;
    
public class Produto
{
    [Key]
    public int Produtoid { get; set; }
    [Required(ErrorMessage = "Campo obrigatório")]
    [StringLength(50)]
    public string? Nome { get; set; }
    [StringLength(200)]
    [Required(ErrorMessage = "Campo obrigatório")]
    public string? Descricao { get; set; }
    [Required(ErrorMessage ="Campo obrigatório")]
    [Column(TypeName = "decimal(10,2)")]
    public double Preco { get; set; }
    [StringLength(100)]
    [Required]
    public string? ImagemUrl { get; set; }
    public double Estoque { get; set; }
    public DateTime DataCadastro { get; set; }  
    public int CategoriaId { get; set; }
    public Categoria? Categoria { get; set; }
}
