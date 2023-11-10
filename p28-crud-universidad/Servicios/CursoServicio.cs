using Microsoft.EntityFrameworkCore;

public class CursoServicio {
private readonly ContextoDatos ctx;
public CursoServicio(ContextoDatos contexto) => ctx = contexto;

public List<Curso> ObtenerTodo(string cadenabuscar) {
var _cursos = ctx.Cursos
.Include(i=>i.Inscripciones)
.ThenInclude(e=>e.Estudiante);
var cursos = from c in _cursos select c;
if(!string.IsNullOrEmpty(cadenabuscar)) {
cursos = cursos.Where(c=>c.Titulo.Contains(cadenabuscar));
}
return cursos.ToList();
}

public bool AgregarActualizar(Curso curso) {
try {
if (curso.CursoId == 0) ctx.Cursos.Add(curso);
else ctx.Cursos.Update(curso);
ctx.SaveChanges();
return true;
}
catch (Exception ex) { return false; }
}
public Curso EcontrarPorId(int Id) {
return ctx.Cursos.Find(Id);

}
public bool Borrar(int id) {
try {
var curso = EcontrarPorId(id);
if(curso==null) return false;
else ctx.Cursos.Remove(curso);
ctx.SaveChanges();
return true;
} catch (Exception ex) { return false; }
}

}