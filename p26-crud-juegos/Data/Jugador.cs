using System.ComponentModel.DataAnnotations;
public class Jugador {
    [Key]
    public int Id {get; set;}
    [Required]
    [MinLength(3, ErrorMessage="Mínimo 3 dígitos"), MaxLength(35, ErrorMessage="Máximo 35 dígitos")]
    public string Nombre {get; set;}
    [Range(typeof(DateTime), "01/01/2000", "31/12/2024", ErrorMessage="Fecha fuera de rango de edad")]
    public DateTime FechaNac {get; set;}
    [Range(1,20, ErrorMessage="No hay playeras con ese número")]
    public int NoPlayera {get; set;}
    public string Posicion {get; set;}
    public int Apariciones {get; set;}
    public int Goles {get; set;}
}