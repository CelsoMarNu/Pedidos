using Microsoft.EntityFrameworkCore;
using System;
using Dominio;

namespace Persistencia
{
    public class Conexion : DbContext
    { 
        public Conexion(DbContextOptions options) : base(options){
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Detalle>().HasKey(ci => new { ci.CodPedido, ci.Descripcion });
        }
        public DbSet<Cabecera> Cabecera { get; set; }
        public DbSet<Detalle> Detalle { get; set; }
    }
}

