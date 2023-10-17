using System.ComponentModel.DataAnnotations;
public class Empleado {
[Key]
public int Id {get; set;}
[Required]
[MinLength(3), MaxLength(35)]
public string Nombre {get; set;}
[RegularExpression(@"[ña-z]{3,4}[0-9]{6}[0-9a-z]{3}$")]
public string Rfc {get; set;}
[Range(18,35)]
public int Edad {get; set;}
public string Genero {get; set;}
[EmailAddress]
public string Correo {get; set;}
public double Salario {get; set;}
}