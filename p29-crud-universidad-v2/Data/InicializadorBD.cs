public class InicializadorBD {
public static void Inicializar(ContextoDatos contexto) {
if(contexto.Estudiantes.Any()) {
return;
}
var estudiantes = new List<Estudiante> {
new Estudiante { Nombre = "Carson", Apeido = "Alexander", FechaInscripcion = DateTime.Parse("2010-09-01") },
new Estudiante { Nombre = "Meredith", Apeido = "Alonso", FechaInscripcion = DateTime.Parse("2012-09-01") },
new Estudiante { Nombre = "Arturo", Apeido = "Anand", FechaInscripcion = DateTime.Parse("2013-09-01") },
new Estudiante { Nombre = "Gytis", Apeido = "Barzdukas", FechaInscripcion = DateTime.Parse("2012-09-01") },
new Estudiante { Nombre = "Yan", Apeido = "Li", FechaInscripcion = DateTime.Parse("2012-09-01") },
new Estudiante { Nombre = "Peggy", Apeido = "Justice", FechaInscripcion = DateTime.Parse("2011-09-01") },
new Estudiante { Nombre = "Laura", Apeido = "Norman", FechaInscripcion = DateTime.Parse("2013-09-01") },
new Estudiante { Nombre = "Nino", Apeido = "Olivetto", FechaInscripcion = DateTime.Parse("2005-09-01") }
};
contexto.Estudiantes.AddRange(estudiantes);
contexto.SaveChanges();
var cursos = new List<Curso> {
new Curso {CursoId = 1050, Titulo = "Química", Creditos = 3},
new Curso {CursoId = 4022, Titulo = "Microeconomía", Creditos = 3},
new Curso {CursoId = 4041, Titulo = "Macroeconomía", Creditos = 3},
new Curso {CursoId = 1045, Titulo = "Cálculo", Creditos = 4},
new Curso {CursoId = 3141, Titulo = "Trigonometría", Creditos = 4},
new Curso {CursoId = 2021, Titulo = "Composición", Creditos = 3},
new Curso {CursoId = 2042, Titulo = "Literatura", Creditos = 4}
};
contexto.Cursos.AddRange(cursos);
contexto.SaveChanges();

var incripciones = new List<Inscripcion>
{
new Inscripcion { EstudianteId = estudiantes.Single(s => s.Apeido == "Alexander").Id,
CursoId = cursos.Single(c => c.Titulo == "Química" ).CursoId, Promedio = 9 },
new Inscripcion { EstudianteId = estudiantes.Single(s => s.Apeido == "Alexander").Id,
CursoId = cursos.Single(c => c.Titulo == "Microeconomía" ).CursoId, Promedio = 10},
new Inscripcion { EstudianteId = estudiantes.Single(s => s.Apeido == "Alexander").Id,
CursoId = cursos.Single(c => c.Titulo == "Macroeconomía" ).CursoId, Promedio = null},
new Inscripcion { EstudianteId = estudiantes.Single(s => s.Apeido == "Alonso").Id,
CursoId = cursos.Single(c => c.Titulo == "Cálculo" ).CursoId, Promedio = null},
new Inscripcion { EstudianteId = estudiantes.Single(s => s.Apeido == "Alonso").Id,
CursoId = cursos.Single(c => c.Titulo == "Trigonometría" ).CursoId, Promedio = null},
new Inscripcion { EstudianteId = estudiantes.Single(s => s.Apeido == "Alonso").Id,
CursoId = cursos.Single(c => c.Titulo == "Composición" ).CursoId, Promedio = null},
new Inscripcion { EstudianteId = estudiantes.Single(s => s.Apeido == "Anand").Id,
CursoId = cursos.Single(c => c.Titulo == "Química" ).CursoId, Promedio = 10 },
new Inscripcion { EstudianteId = estudiantes.Single(s => s.Apeido == "Anand").Id,
CursoId = cursos.Single(c => c.Titulo == "Microeconomía").CursoId, Promedio = null},
new Inscripcion { EstudianteId = estudiantes.Single(s => s.Apeido == "Barzdukas").Id,
CursoId = cursos.Single(c => c.Titulo == "Química").CursoId, Promedio = null},
new Inscripcion { EstudianteId = estudiantes.Single(s => s.Apeido == "Li").Id,
CursoId = cursos.Single(c => c.Titulo == "Composición").CursoId, Promedio = null},
new Inscripcion { EstudianteId = estudiantes.Single(s => s.Apeido == "Justice").Id,
CursoId = cursos.Single(c => c.Titulo == "Literatura").CursoId, Promedio = null}
};
contexto.Inscripciones.AddRange(incripciones);
contexto.SaveChanges();
}
}