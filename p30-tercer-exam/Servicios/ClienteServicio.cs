// Servicios/ClienteServicio.cs
using Microsoft.EntityFrameworkCore;
public class ClienteServicio {
private readonly ContextoDatos ctx;
public ClienteServicio(ContextoDatos contexto) => ctx = contexto;
public List<Cliente> ObtenerTodo(string cadenabuscar) {
var _clientes = ctx.Clientes
.Include(i=>i.Reservas)
.ThenInclude(c=>c.Habitacion);
var clientes = from e in _clientes select e;
if(!string.IsNullOrEmpty(cadenabuscar)) {

clientes = clientes.Where(e=>e.Apellido.Contains(cadenabuscar) || e.Nombre.Contains(cadenabuscar));

}
return clientes.ToList();
}
public bool AgregarActualizar(Cliente cliente) {
try {
if (cliente.Id == 0) ctx.Clientes.Add(cliente);
else ctx.Clientes.Update(cliente);
ctx.SaveChanges();
return true;
}
catch (Exception ex) { return false; }
}
public Cliente EcontrarPorId(int Id) {
return ctx.Clientes.Find(Id);
}
public bool Borrar(int id) {
try {
var cliente = EcontrarPorId(id);
if(cliente==null) return false;
else ctx.Clientes.Remove(cliente);
ctx.SaveChanges();
return true;
} catch (Exception ex) { return false; }
}
}