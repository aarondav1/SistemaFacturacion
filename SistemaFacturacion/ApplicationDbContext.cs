using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;

namespace SistemaFacturacionWebApiREST
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<AsignacionRutaParada>().HasKey(arp => new { arp.Id_Ruta, arp.Id_Parada });
        //}

        //TABLAS
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<DetalleFactura> DetalleFacturas { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Reembolso> Reembolsos { get; set; }
        public DbSet<Servicio> Servicios { get; set; }

    }
}
