using System;

namespace MercadoWEB.Models
{
    public class ProductoModel
    {
        public int IdProducto { get; set; }
        public int IdCategoria { get; set; }
        public string Categoria { get; set; }
        public string NombreProducto { get; set; }
        public decimal Precio { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
