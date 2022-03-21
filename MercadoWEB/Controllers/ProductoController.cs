using MercadoWEB.Data;
using MercadoWEB.Models;
using MercadoWEB.Models.BL;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MercadoWEB.Controllers
{
    
    public class ProductoController : Controller
    {
        private MercadoContext _context;
        public ProductoController(MercadoContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var productos = new ProductoBL(_context).GetProductos();

            return View("Productos",productos);
        }
    }
}
