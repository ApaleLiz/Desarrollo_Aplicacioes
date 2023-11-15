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
            new Cliente { Nombre = "Felipe", Apellido = "Guzman", Genero = 'M', FechaCumple = DateTime.Parse("1998-05-15"), Correo = "Fel@gmail.com", Telefono = "4921582395" },
            new Cliente { Nombre = "Paola", Apellido = "Roque", Genero = 'F', FechaCumple = DateTime.Parse("1985-08-22"), Correo = "Pao@gmail.com", Telefono = "7521452896" },
            new Cliente { Nombre = "Jhoan", Apellido = "Duran", Genero = 'M', FechaCumple = DateTime.Parse("2000-03-10"), Correo = "jhos@gmail.com", Telefono = "4562397841" },
            new Cliente { Nombre = "Marely", Apellido = "Martínez", Genero = 'F', FechaCumple = DateTime.Parse("2007-12-01"), Correo = "Mar@gmail.com", Telefono = "2721014586" },
            new Cliente { Nombre = "Camilo", Apellido = "González", Genero = 'M', FechaCumple = DateTime.Parse("1900-07-18"), Correo = "Beee@gmail.com", Telefono = "2714857963" },
            new Cliente { Nombre = "Teresa", Apellido = "Rodriguez", Genero = 'F', FechaCumple = DateTime.Parse("2001-09-25"), Correo = "Cal@gmail.com", Telefono = "8984562321" },
            new Cliente { Nombre = "Elena", Apellido = "Apale", Genero = 'F', FechaCumple = DateTime.Parse("1879-04-14"), Correo = "Ele@gmail.com", Telefono = "9984574926" }
        };
        contexto.Clientes.AddRange(clientes);
        contexto.SaveChanges();

        // Inicializar datos de habitaciones
        var habitaciones = new List<Habitacion>
        {
             new Habitacion {Id = 1, NoHab = 101, Tipo = "Doble", Piso = 1, Costo = 160.00 },
            new Habitacion { Id = 2, NoHab = 102, Tipo = "Doble", Piso = 1, Costo = 160.00 },
            new Habitacion { Id = 3, NoHab = 201, Tipo = "Individual", Piso = 2, Costo = 100.00 },
            new Habitacion { Id = 4, NoHab = 202, Tipo = "Individual", Piso = 2, Costo = 100.00 },
            new Habitacion { Id = 5, NoHab = 301, Tipo = "Suite", Piso = 3, Costo = 200.00 },
            new Habitacion { Id = 6, NoHab = 302, Tipo = "Suite", Piso = 3, Costo = 200.00 },
            new Habitacion { Id = 7, NoHab = 401, Tipo = "Presidencial", Piso = 4, Costo = 300.00 },
            new Habitacion { Id = 8, NoHab = 402, Tipo = "Presidencial", Piso = 4, Costo = 300.00 }
          
        };
        contexto.Habitaciones.AddRange(habitaciones);
        contexto.SaveChanges();

        // Inicializar datos de reservas
        var reservas = new List<Reserva>
        {
            new Reserva { HabitacionId = 1, ClienteId = 1, InicioReserva = DateTime.Parse("2023-08-03"), FinReserva = DateTime.Parse("2023-08-11") },
            new Reserva { HabitacionId = 2, ClienteId = 2, InicioReserva = DateTime.Parse("2023-02-01"), FinReserva = DateTime.Parse("2023-02-07") },
             new Reserva { HabitacionId = 3, ClienteId = 3, InicioReserva = DateTime.Parse("2023-01-01"), FinReserva = DateTime.Parse("2023-01-07") },
            new Reserva { HabitacionId = 4, ClienteId = 4, InicioReserva = DateTime.Parse("2023-01-01"), FinReserva = DateTime.Parse("2023-01-07") }
           
        };
        contexto.Reservas.AddRange(reservas);
        contexto.SaveChanges();
    }
}