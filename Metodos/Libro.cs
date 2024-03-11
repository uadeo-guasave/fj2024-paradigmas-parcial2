namespace Metodos;

public class Libro
{
    public int Id { get; private set; }
    public string Titulo { get; set; }
    public int Edicion { get; set; }
    public int Año { get; set; }
    public string Isbn { get; set; }
    public string Portada { get; set; }
    public string Idioma { get; set; }
    public int NúmeroDePáginas { get; set; }
    public string Editorial { get; set; }
    public string Autores { get; set; }
    public string Categoría { get; set; }

    // constructor
    public Libro()
    {
        Id = new Random().Next(1,1000);
    }
}
