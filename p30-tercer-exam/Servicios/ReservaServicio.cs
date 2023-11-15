using Microsoft.EntityFrameworkCore;
public class ReservaServicio {
    private readonly ContextoDatos ctx;
    public ReservaServicio(ContextoDatos contexto) => ctx = contexto;
    public List<Reserva> ObtenerTodo() {
        return ctx.Reservas
        .Include(c=>c.Habitacion)
        .Include(e=>e.Cliente)
        .ToList();
    }
    public bool AgregarActualizar(Reserva reserva) {
        try {
            if (reserva.Id == 0) ctx.Reservas.Add(reserva);
            else ctx.Reservas.Update(reserva);
            ctx.SaveChanges();
            return true;
        }
        catch (Exception ex) { return false; }
    }
    public Reserva EcontrarPorId(int Id) {
        return ctx.Reservas.Find(Id);
    }
    public bool Borrar(int id) {
        try {
            var reserva = EcontrarPorId(id);
            if(reserva==null) return false;
            else ctx.Reservas.Remove(reserva);
            ctx.SaveChanges();
            return true;
        } catch (Exception ex) { return false; }
    }

    public int Total(){
        return ctx.Reservas.Count();
    }
}