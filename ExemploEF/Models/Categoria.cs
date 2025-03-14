using System;
using System.ComponentModel.DataAnnotations;

namespace ExemploEF.Models
{
    public class Categoria
    {
        [Key]
        public Guid CategoriaID { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
        // Relacionando as entidades Produto e Categoria (1 Categoria N Produtos) 
        // Cada categoria pode conter muitos produtos 
        public IEnumerable<Produto>? Produtos { get; set; }
    }
}