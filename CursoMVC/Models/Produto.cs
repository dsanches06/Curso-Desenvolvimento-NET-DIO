using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{
    public class Produto
    {
        
        public int Id { get; set; }

        [Display(Name ="Descrição")]
        [Required (ErrorMessage = "O campo descrição é obrigatório")]
        public string Descricao { get; set; }

        [Range(1, 100, ErrorMessage = "O valor minímo é 1 e valor maximo é 100")]
        public int Quantidade { get; set; }

        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
