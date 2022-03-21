using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MercadoWEB.Models.Entidades
{
    public class Rol
    {
        [Key]
        public int IdRol { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(100)]
        public string NombreRol { get; set; }
        [Required]
        [StringLength(4)]
        public string Abreviatura { get; set; }        
    }
}
