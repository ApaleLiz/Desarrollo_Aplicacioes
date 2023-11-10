using System;
using System.ComponentModel.DataAnnotations;

public class Reserva
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Se requiere una habitación para la reserva.")]
    public int HabitacionId { get; set; }

    [Required(ErrorMessage = "Se requiere un cliente para la reserva.")]
    public int ClienteId { get; set; }

    [Display(Name = "Fecha de Inicio de la Reserva")]
    [DataType(DataType.Date)]
    public DateTime InicioReserva { get; set; }

    [Display(Name = "Fecha de Fin de la Reserva")]
    [DataType(DataType.Date)]
    public DateTime FinReserva { get; set; }

    public int DiasReserva => (FinReserva - InicioReserva).Days;

    public Habitacion Habitacion { get; set; }

    public Cliente Cliente { get; set; }
}