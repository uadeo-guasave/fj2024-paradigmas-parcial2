namespace ClasesObjetos;

public class Coppel : Credito
{
    public string Referencia { get; set; }
    public bool Opinion { get; set; }

    public void valorarOpinion()
    {
        Aumento = Opinion;
        if (Aumento)
        {
            aumentarLimite(5000);
        }
    }
}
