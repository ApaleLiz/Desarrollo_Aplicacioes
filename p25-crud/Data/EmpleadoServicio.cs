public class EmpleadoServicio {
private readonly ContextoDatos ctx;
public EmpleadoServicio(ContextoDatos contexto) => ctx = contexto;
public List<Empleado> ObtenerTodo() {
return ctx.Empleados.ToList();
}
public bool AgregarActualizar(Empleado empleado) {
try {
if (empleado.Id == 0) ctx.Empleados.Add(empleado);
else ctx.Empleados.Update(empleado);
ctx.SaveChanges();
return true;
}
catch (Exception ex) { return false; }
}
public Empleado EcontrarPorId(int Id) {
return ctx.Empleados.Find(Id);
}
public bool Borrar(int id) {
try {
var empleado = EcontrarPorId(id);
if(empleado==null) return false;
else ctx.Empleados.Remove(empleado);
ctx.SaveChanges();
return true;
} catch (Exception ex) { return false; }
}
}