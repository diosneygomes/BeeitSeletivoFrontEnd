using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.ViewModels
{
    public class NumeroViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = ("O menor número que pode ser digitado é 1"))] 
        public int Valor { get; set; }
        
        public int Resultado { get; set; }
        
        public string Expressao { get; set; }
    }
}
