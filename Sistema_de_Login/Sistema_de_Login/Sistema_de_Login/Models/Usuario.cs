using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema_de_Login.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "Campo Login é obrigatório!")]
        public string Login {get; set;}
       
        [Required(ErrorMessage = "Campo Senha é obrigatório!")]
        public string Senha{ get; set; }
    }
}
