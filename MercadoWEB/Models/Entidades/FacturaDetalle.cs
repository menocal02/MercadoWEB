using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MercadoWEB.Models.Entidades
{
    public class FacturaDetalle
    {
        [Key]
        public int IdFacturaDetalle { get; set; }
        [Required]
        public int IdFactura { get; set; }
        [Required]
        public int IdCliente { get; set; }
        [Required]
        public int IdProducto { get; set; }
        [Required]
        public int cantidad { get; set; }
        [Required]
        public decimal PrecioUnit { get; set; }
        [Required]
        public decimal Descuento { get; set; }
    }
}
