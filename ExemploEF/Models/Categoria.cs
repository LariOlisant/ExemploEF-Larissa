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
    }
}