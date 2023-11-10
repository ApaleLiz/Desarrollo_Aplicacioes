using Microsoft.EntityFrameworkCore;
public class ContextoDatos : DbContext {
public ContextoDatos(DbContextOptions<ContextoDatos> options) :
base(options) {
}
public DbSet<Curso> Cursos { get; set; }
public DbSet<Inscripcion> Inscripciones { get; set; }
public DbSet<Estudiante> Estudiantes { get; set; }
}

