
using MercadoWEB.Models.Entidades;
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
        public DbSet<Categoria> Categoria{ get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Factura> Factura { get; set; }
        public DbSet<FacturaDetalle> FacturaDetalle { get; set; }
        public DbSet<Modulo> Modulo { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Propietario> Propietario { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

    }
}
