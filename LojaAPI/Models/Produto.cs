using Microsoft.AspNetCore.Mvc.Formatters;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LojaAPI.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} deve possuir no máximo 50 caracteres")]
        public string Nome { get; set; }

        [StringLength(1000, ErrorMessage = "O campo {0} deve possuir no máximo 1000 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Range(0.01, int.MaxValue, ErrorMessage = "O Preço deve ser maior que zero")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

    }
}
