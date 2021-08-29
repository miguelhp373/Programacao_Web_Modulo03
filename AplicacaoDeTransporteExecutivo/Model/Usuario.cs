using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace TransporteExecutivo.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "Campo nome é obrigatório!")]
        [MaxLength(40, ErrorMessage = "Campo nome pode ter no máximo 40 caracters!")]
        public string nome { get; set; }

        [Required(ErrorMessage = "Campo telefone é obrigatório!")]
        [MaxLength(15, ErrorMessage = "Campo telefone pode ter no máximo 15 caracters!")]
        public string telefone { get; set; }

        [Required(ErrorMessage = "Campo ida é obrigatório!")]
        public string ida { get; set; }

        [Required(ErrorMessage = "Campo volta é obrigatório!")]
        public string volta { get; set; }
    }
}
