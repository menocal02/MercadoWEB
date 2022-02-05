using MercadoWEB.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MercadoWEB.Controllers
{
    public class ProductoController : Controller
    {
        public IActionResult Index()
        {
            var productos = new List<ProductoModel>() 
            {
                new ProductoModel(){ NombreProducto = "Arroz", Descripcion="80% grano entero", Categoria="Granos básicos", Precio = 15},
                new ProductoModel(){ NombreProducto = "Frijoles", Descripcion="grano rojo", Categoria="Granos básicos", Precio = 22},
                new ProductoModel(){ NombreProducto = "Gaseosa", Descripcion="grano rojo", Categoria="Bebidas", Precio = 30}
            };

            return View("Productos",productos);
        }
    }
}
