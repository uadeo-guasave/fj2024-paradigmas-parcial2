namespace ClasesObjetos;

public class Persona2
{
    string nombre;
    public string Nombre
    {
        get { return nombre.ToUpper(); }
        set { nombre = value.ToLower(); }
    }

    public string Apellidos { get; set; }
}
