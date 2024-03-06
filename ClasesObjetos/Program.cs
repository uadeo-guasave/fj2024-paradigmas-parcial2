
namespace ClasesObjetos;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hola C# a la antigüa");
        definirCoche();
        definirCreditos();
    }

    private static void definirCreditos()
    {
        var banco = new Credito();
        // banco.Id = 21321321;
        Console.WriteLine(banco.Id);
        // banco.limite = 6000;
        banco.Cliente = "Bidkar";
        // banco.Aumento = true;
        var coppel = new Coppel();
        Console.WriteLine("Coppel Id: {0}", coppel.Id);
        coppel.Cliente = "Leobardo";
        coppel.Referencia = "Aarel";
        coppel.Opinion = false;
        coppel.valorarOpinion();
    }

    private static void definirCoche()
    {
        var sentra = new Coche();
        sentra.Marca = "Nissan";
        sentra.Modelo = 2020;
        sentra.setRuedas(4);
        sentra.Cilindros = 4;
    }
}
