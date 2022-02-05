using MercadoWEB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MercadoWEB.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            var productos = new List<Producto>() 
            {
                new Producto(){ NombreProducto = "Arroz", Descripcion="80% grano entero", Precio = 15},
                new Producto(){ NombreProducto = "Frijoles", Descripcion="grano rojo", Precio = 22},
                new Producto(){ NombreProducto = "Gaseosa", Descripcion="grano rojo", Precio = 30}
            };

            return View("Productos",productos);
        }
    }
}
