using MercadoWEB.Models;
using Microsoft.EntityFrameworkCore;

namespace MercadoWEB.Data
{
    public class MercadoContext : DbContext
    {
        /* Comandos de migraciones para MercadoContext
         * add-migration migracionProducto -context MercadoContext
         * update-Database -context MercadoContext         
         */

        public MercadoContext(DbContextOptions<MercadoContext> options) : base(options)
        { 
        
        }
        public DbSet<Producto> Producto{ get; set; }
        
    }
}
