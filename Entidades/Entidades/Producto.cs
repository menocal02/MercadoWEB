using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entidades.Entidades
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }      
        [Required(ErrorMessage = "Campo requerido")]
        public int IdCategoria { get; set; }        
        [StringLength(500)]
        [Required(ErrorMessage ="Campo requerido")]
        public string NombreProducto { get; set; }       
        [Required(ErrorMessage = "Campo requerido")]
        public decimal Precio { get; set; }
        [StringLength(2000)]
        [Required(ErrorMessage = "Campo requerido")]
        public string Descripcion { get; set; }
        [Required]
        public DateTime FechaCreacion { get; set; }
    }
}
