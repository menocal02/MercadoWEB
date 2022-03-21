using System;
using System.ComponentModel.DataAnnotations;

namespace MercadoWEB.Models.Entidades
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        [Required(ErrorMessage = "Campo requerido")]        
        public int IdModulo { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public int IdCategoria { get; set; }
        [StringLength(500)]
        [Required(ErrorMessage = "Campo requerido")]
        public string NombreProducto { get; set; }
        [Required(ErrorMessage = "Campo requerido")]
        public decimal Precio { get; set; }
        [Required]
        public decimal Existencia { get; set; }
        [Required]
        public decimal ExistenciaMinima { get; set; }
        [Required]
        public decimal Descuento { get; set; }
        [StringLength(2000)]
        [Required(ErrorMessage = "Campo requerido")]
        public string Descripcion { get; set; }
        public byte[] Foto { get; set; }
        [Required]
        public bool Estado { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
    }
}
