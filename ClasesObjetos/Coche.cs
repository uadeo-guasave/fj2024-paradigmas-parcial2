namespace ClasesObjetos;

public class Coche
{
    public string Marca { get; set; }
    public int Modelo { get; set; }
    private int ruedas;
    public string Color { get; set; }
    private int cilindros;
    public int Cilindros
    {
        get { return cilindros; }
        set { cilindros = value; }
    }
    public Persona Chofer { get; private set; }

    public void setRuedas(int ruedas)
    {
        this.ruedas = ruedas;
    }
}
