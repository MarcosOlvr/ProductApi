using System.ComponentModel.DataAnnotations;

namespace ProductApi.Models;

public class Produto
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string Nome { get; set; }
    
    [Required]
    public float Preco { get; set; }
    
    public int Quantidade { get; set; } = 0;
    public Categoria Categoria { get; set; }
    public DateTime CriadoEm { get; set; } = DateTime.Now;
    public DateTime AtualizadoEm { get; set; } = DateTime.Now;
}