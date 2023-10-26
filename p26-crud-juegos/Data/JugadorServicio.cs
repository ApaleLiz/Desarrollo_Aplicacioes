public class JugadorServicio {
    private readonly ContextoDatos ctx;
    public JugadorServicio(ContextoDatos contexto) => ctx = contexto;
    public List<Jugador> ObtenerTodo() {
        return ctx.Jugadores.ToList();
    }
    public bool AgregarActualizar(Jugador jugador) {
        try {
            if (jugador.Id == 0) ctx.Jugadores.Add(jugador);
                else ctx.Jugadores.Update(jugador);
                ctx.SaveChanges();
                return true;
        }
        catch (Exception ex) { return false; }
    }
    public Jugador EcontrarPorId(int Id) {
        return ctx.Jugadores.Find(Id);
    }
    public bool Borrar(int id) {
        try {
            var jugador = EcontrarPorId(id);
            if(jugador==null) return false;
                else ctx.Jugadores.Remove(jugador);
                ctx.SaveChanges();
                return true;
        } catch (Exception ex) { return false; }
    }
}