using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MercadoWEB.Models.Entidades
{
    public class Modulo
    {
        [Key]
        public int IdModulo { get; set; }
        [Required]
        public int IdPropietario { get; set; }        
        [Required(ErrorMessage = "Campo requerido")]
        [StringLength(2000)]
        public string Descripcion { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
    }
}
