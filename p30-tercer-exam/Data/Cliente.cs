using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Cliente
{
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [StringLength(30, ErrorMessage = "La longitud máxima del nombre es 30 caracteres.")]
    public string Nombre { get; set; }

    [Required(ErrorMessage = "El apellido es obligatorio.")]
    [StringLength(30, ErrorMessage = "La longitud máxima del apellido es 30 caracteres.")]
    public string Apellido { get; set; }

    public char Genero { get; set; }

    [Display(Name = "Fecha de Nacimiento")]
    [DataType(DataType.Date)]
    public DateTime FechaCumple { get; set; }

    [Required(ErrorMessage = "El correo es obligatorio.")]
    [EmailAddress(ErrorMessage = "Ingrese una dirección de correo electrónico válida.")]
    public string Correo { get; set; }

    [Required(ErrorMessage = "El teléfono es obligatorio.")]
    [RegularExpression(@"^\d{10}$", ErrorMessage = "Ingrese un número de teléfono válido de 10 dígitos.")]
    public string Telefono { get; set; }

    public string NombreCompleto => $"{Nombre} {Apellido}";

    public ICollection<Reserva> Reservas { get; set; }

     public int ObtenerEdadEnAños(){
            var hoy = DateTime.Today;
            var edad = hoy.Year - FechaCumple.Year;

            // Restar un año si aún no ha pasado el cumpleaños este año
            if (FechaCumple.Date > hoy.AddYears(-edad))
                edad--;

            return edad;
        }
}