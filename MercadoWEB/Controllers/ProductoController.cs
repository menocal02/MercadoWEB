using MercadoWEB.Data;
using MercadoWEB.Models;
using MercadoWEB.Models.BL;
using MercadoWEB.Models.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
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

        public IActionResult InsertProducto(Producto p)
        {
            try
            {
                var ret = new ProductoBL(_context).InsertProductos(p);

                return Json(new { result = ret, mensaje = "Registro guardado satisfactoriamente" });
            }
            catch (Exception ex) 
            {
                return Json(new { result = false, mensaje = ex.Message });
            }
        }
    }
}