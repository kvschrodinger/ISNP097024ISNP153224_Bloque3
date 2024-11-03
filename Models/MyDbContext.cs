using Microsoft.EntityFrameworkCore;
using ISNP097024ISNP153224_Bloque3.Models;

namespace ISNP097024ISNP153224_Bloque3.Models {
    public class MyDbContext : DbContext{
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Pelicula> Peliculas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Pelicula>().HasKey(pelicula => pelicula.IdPelicula); 
           
        }
    }
}