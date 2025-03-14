using System.ComponentModel.DataAnnotations;

namespace ExemploEF.Models
{
    public class Produto
        {
        //Quando houver relacionamentos, você deve especificar a chave primária com [Key]
            [Key]
            public Guid ProdutoId { get; set; }
            public string Nome { get; set; }
            public int Estoque { get; set; }
            // Relacionando as entidades Produto e Categoria (1 Categoria -N Produtos) 
            // Cada produto pode pertencer apenas a uma categoria 
            public Guid CategoriaID { get; set; }
            public Categoria? Categoria { get; set; }
        }
    }
    
