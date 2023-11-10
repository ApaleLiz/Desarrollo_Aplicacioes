using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
public class Habitacion {
[DatabaseGenerated(DatabaseGeneratedOption.None)]
public int Id { get; set; }

[Range(1, 30)]
public int NoHab { get; set; }

[StringLength(10, MinimumLength = 0)]
public string Tipo { get; set; }

[Range(1, 4)]
public int Piso { get; set; }

[Range(1,5000, ErrorMessage="Sobrepasa el precio")]
    public double Costo {get; set;}
public ICollection<Reserva> Reservas { get; set; }
}