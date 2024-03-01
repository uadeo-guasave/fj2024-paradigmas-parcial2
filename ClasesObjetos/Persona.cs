namespace ClasesObjetos;

// una clase es como una plantilla para crear objetos
// nos permite extender el lenguaje y tener tipos de
// datos que no vienen con el mismo
public class Persona
{
    // una clase puede contener atributos y acciones
    // en terminos técnicos atributos o propiedades
    // los atributos por lo general son privados
    string nombre;
    // cuando una característica no tiene modificador de acceso
    // será private por default

    // acciones o métodos o funciones
    public string getNombre()
    {
        return nombre.ToUpper();
    }

    public void setNombre(string value)
    {
        nombre = value.ToLower();
    }
}
