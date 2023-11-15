using Microsoft.EntityFrameworkCore;

public class HabitacionServicio
{
    private readonly ContextoDatos ctx;

    public HabitacionServicio(ContextoDatos contexto) => ctx = contexto;

    public List<Habitacion> ObtenerTodo(string cadenabuscar)
    {
        var _habitaciones = ctx.Habitaciones;
        var habitaciones = from c in _habitaciones select c;

        if (!string.IsNullOrEmpty(cadenabuscar))
        {
            habitaciones = habitaciones.Where(c=>c.Tipo.Contains(cadenabuscar));
        }
        return habitaciones.ToList();
    }

    public bool AgregarActualizar(Habitacion habitacion)
    {
        try
        {
            if (habitacion.Id == 0) ctx.Habitaciones.Add(habitacion);
            else ctx.Habitaciones.Update(habitacion);
            ctx.SaveChanges();
            return true;
        }
        catch (Exception ex){
            return false;
        }
    }

    public Habitacion EcontrarPorId(int Id)
    {
        return ctx.Habitaciones.Find(Id);
    }

    public bool Borrar(int id)
    {
        try
        {
            var habitacion = EcontrarPorId(id);
            if (habitacion == null)
                return false;
            else
                ctx.Habitaciones.Remove(habitacion);

            ctx.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public int TotalByType(string roomType){
        return ctx.Habitaciones.Count(x => x.Tipo == roomType);
    }

}