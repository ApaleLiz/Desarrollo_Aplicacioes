using Microsoft.EntityFrameworkCore;
public class InscripcionServicio {
private readonly ContextoDatos ctx;
public InscripcionServicio(ContextoDatos contexto) => ctx = contexto;
public List<Inscripcion> ObtenerTodo() {
return ctx.Inscripciones
.Include(c=>c.Curso)
.Include(e=>e.Estudiante)
.ToList();
}
public bool AgregarActualizar(Inscripcion inscripcion) {
try {
if (inscripcion.InscripcionId == 0) ctx.Inscripciones.Add(inscripcion);
else ctx.Inscripciones.Update(inscripcion);
ctx.SaveChanges();
return true;
}
catch (Exception ex) { return false; }
}
public Inscripcion EcontrarPorId(int Id) {
return ctx.Inscripciones.Find(Id);
}
public bool Borrar(int id) {
try {
var inscripcion = EcontrarPorId(id);
if(inscripcion==null) return false;
else ctx.Inscripciones.Remove(inscripcion);
ctx.SaveChanges();
return true;
} catch (Exception ex) { return false; }
}
}