namespace ClasesObjetos;

// define las propiedades Nombre, Apellidos, Curp para Alumno
// define el atributo edad para Alumno
// define la propiedad Id para Alumno y que se genere
// de forma aleatoria al construir un objeto
// define la propiedad FechaDeNacimiento
// define un método para calcular la edad

public class Alumno
{
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public string Curp { get; set; }
    public DateTime FechaDeNacimiento { get; set; }
    private int edad;
}
