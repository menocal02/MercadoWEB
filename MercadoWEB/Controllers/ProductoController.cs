using MercadoWEB.Data;
using MercadoWEB.Models;
using MercadoWEB.Models.BL;
using MercadoWEB.Models.Entidades;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;

namespace MercadoWEB.Controllers
{
    
    public class ProductoController : Controller
    {
        private MercadoContext _context;
       
        public ProductoController(MercadoContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            return View("Productos");
        }

        public ActionResult GetProductos()
        {
            var data = new ProductoBL(_context).GetProductos();

            return Json(new { data = data });
        }

        [HttpPost]
        public IActionResult InsertProducto(IFormFile fuFoto, Producto p)
        {
            try
            {
                if (fuFoto != null && fuFoto.Length > 0)
                {
                    byte[] bytes;
                    using (var reader = new BinaryReader(fuFoto.OpenReadStream()))
                    {
                        bytes = reader.ReadBytes((int)fuFoto.Length);
                        p.Foto = bytes;
                    }
                }

                p.Estado = true;
                p.FechaCreacion = DateTime.Now;

                var ret = new ProductoBL(_context).InsertProductos(p);

                return View("Productos");
            }
            catch (Exception ex) 
            {
                return Json(new { result = false, mensaje = ex.Message });
            }
        }
    }
}