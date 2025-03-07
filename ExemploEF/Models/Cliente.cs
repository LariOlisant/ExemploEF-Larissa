using System;
using System.ComponentModel.DataAnnotations;

namespace ExemploEF.Models
{
    public class Cliente
    {
        [Key]
        public Guid ClienteID { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Nascimento { get; set; }
    }
}
