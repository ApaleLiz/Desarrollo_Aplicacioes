public class InicializadorBD
{
    public static void Inicializar(ContextoDatos contexto)
    {
        if (contexto.Clientes.Any() || contexto.Habitaciones.Any() || contexto.Reservas.Any())
        {
            return; // La base de datos ya ha sido inicializada
        }

        // Inicializar datos de clientes
        var clientes = new List<Cliente>
        {
            new Cliente { Nombre = "Juan", Apellido = "Pérez", Genero = 'M', FechaCumple = DateTime.Parse("1990-05-15"), Correo = "juan@example.com", Telefono = "1234567890" },
            new Cliente { Nombre = "María", Apellido = "Gómez", Genero = 'F', FechaCumple = DateTime.Parse("1985-08-22"), Correo = "maria@example.com", Telefono = "9876543210" },
            new Cliente { Nombre = "Carlos", Apellido = "Rodríguez", Genero = 'M', FechaCumple = DateTime.Parse("1982-03-10"), Correo = "carlos@example.com", Telefono = "5555555555" },
            new Cliente { Nombre = "Laura", Apellido = "Martínez", Genero = 'F', FechaCumple = DateTime.Parse("1995-12-01"), Correo = "laura@example.com", Telefono = "7777777777" },
            new Cliente { Nombre = "Luis", Apellido = "González", Genero = 'M', FechaCumple = DateTime.Parse("1988-07-18"), Correo = "luis@example.com", Telefono = "8888888888" },
            new Cliente { Nombre = "Ana", Apellido = "Sánchez", Genero = 'F', FechaCumple = DateTime.Parse("1993-09-25"), Correo = "ana@example.com", Telefono = "9999999999" },
            new Cliente { Nombre = "Pedro", Apellido = "López", Genero = 'M', FechaCumple = DateTime.Parse("1987-11-05"), Correo = "pedro@example.com", Telefono = "6666666666" },
            new Cliente { Nombre = "Sofía", Apellido = "Díaz", Genero = 'F', FechaCumple = DateTime.Parse("1998-04-14"), Correo = "sofia@example.com", Telefono = "4444444444" }
        };
        contexto.Clientes.AddRange(clientes);
        contexto.SaveChanges();

        // Inicializar datos de habitaciones
        var habitaciones = new List<Habitacion>
        {
             new Habitacion {Id = 1, NoHab = 101, Tipo = "Doble", Piso = 1, Costo = 150.00 },
            new Habitacion { Id = 2, NoHab = 102, Tipo = "Doble", Piso = 1, Costo = 150.00 },
            new Habitacion { Id = 3, NoHab = 201, Tipo = "Individual", Piso = 2, Costo = 100.00 },
            new Habitacion { Id = 4, NoHab = 202, Tipo = "Individual", Piso = 2, Costo = 100.00 },
            new Habitacion { Id = 5, NoHab = 301, Tipo = "Suite", Piso = 3, Costo = 200.00 },
            new Habitacion { Id = 6, NoHab = 302, Tipo = "Suite", Piso = 3, Costo = 200.00 },
            new Habitacion { Id = 7, NoHab = 401, Tipo = "Presidencial", Piso = 4, Costo = 300.00 },
            new Habitacion { Id = 8, NoHab = 402, Tipo = "Presidencial", Piso = 4, Costo = 300.00 },
            new Habitacion { Id = 9, NoHab = 103, Tipo = "Doble", Piso = 1, Costo = 150.00 },
            new Habitacion { Id = 10, NoHab = 203, Tipo = "Individual", Piso = 2, Costo = 100.00 }
        };
        contexto.Habitaciones.AddRange(habitaciones);
        contexto.SaveChanges();

        // Inicializar datos de reservas
        var reservas = new List<Reserva>
        {
            new Reserva { HabitacionId = 1, ClienteId = 1, InicioReserva = DateTime.Parse("2023-01-01"), FinReserva = DateTime.Parse("2023-01-07") },
            new Reserva { HabitacionId = 2, ClienteId = 2, InicioReserva = DateTime.Parse("2023-02-01"), FinReserva = DateTime.Parse("2023-02-07") },
        };
        contexto.Reservas.AddRange(reservas);
        contexto.SaveChanges();
    }
}