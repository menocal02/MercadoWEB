using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MercadoWEB.Models.Entidades
{
    public class Factura
    {
        [Key]
        public int IdFactura { get; set; }
        [Required]
        public int IdModulo { get; set; }
        [Required]  
        [StringLength(500)]
        public string Referencia { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
    }
}
