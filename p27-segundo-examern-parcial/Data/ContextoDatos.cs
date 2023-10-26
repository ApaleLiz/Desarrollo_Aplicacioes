using Microsoft.EntityFrameworkCore;
public class ContextoDatos : DbContext {
    public ContextoDatos(DbContextOptions<ContextoDatos> opciones) : base(opciones) {}
    public DbSet<Articulo> Articulos {get; set;}
}