namespace ClasesObjetos;

public class Credito
{
    public int Id { get; }
    private double limite = 3000;
    public string Cliente { get; set; }
    protected bool Aumento { get; set; }

    // Constructor
    // es el primero que se ejecuta
    // cuando se crea un objeto
    public Credito()
    {
        Id = new Random().Next(1, 1000);
    }

    protected void aumentarLimite(double nuevoLimite)
    {
        limite = nuevoLimite;
    }
}
