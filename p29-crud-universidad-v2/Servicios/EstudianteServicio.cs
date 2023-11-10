using Microsoft.EntityFrameworkCore;
public class EstudianteServicio {
private readonly ContextoDatos ctx;
public EstudianteServicio(ContextoDatos contexto) => ctx = contexto;

public List<Estudiante> ObtenerTodo(string cadenabuscar) {
var _estudiantes = ctx.Estudiantes
.Include(i=>i.Inscripciones)
.ThenInclude(c=>c.Curso);
var estudiantes = from e in _estudiantes select e;
if(!string.IsNullOrEmpty(cadenabuscar)) {
estudiantes = estudiantes.Where(e=>e.Apeido.Contains(cadenabuscar) || e.Nombre.Contains(cadenabuscar));
}
return estudiantes.ToList();
}

public bool AgregarActualizar(Estudiante estudiante) {
try {
if (estudiante.Id == 0) ctx.Estudiantes.Add(estudiante);
else ctx.Estudiantes.Update(estudiante);
ctx.SaveChanges();
return true;
}
catch (Exception ex) { return false; }
}
public Estudiante EcontrarPorId(int Id) {
return ctx.Estudiantes.Find(Id);
}
public bool Borrar(int id) {
try {
var estudiante = EcontrarPorId(id);
if(estudiante==null) return false;
else ctx.Estudiantes.Remove(estudiante);
ctx.SaveChanges();
return true;
} catch (Exception ex) { return false; }
}
}