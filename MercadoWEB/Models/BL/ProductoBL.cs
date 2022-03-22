using MercadoWEB.Data;
using MercadoWEB.Models.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MercadoWEB.Models.BL
{
    public class ProductoBL
    {
        private MercadoContext _context;
        public ProductoBL(MercadoContext context) 
        {
            _context = context;
        }        

        public List<Producto> GetProductos() 
        {
            var productos = _context.Producto.ToList();

            return productos;
        }

        public bool InsertProductos(Producto p)
        {
            var ret = false;

            _context.Producto.Add(p);
            _context.SaveChanges();

            ret = true;

            return ret;
        }
    }
}
