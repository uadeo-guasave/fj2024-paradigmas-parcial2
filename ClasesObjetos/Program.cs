
namespace ClasesObjetos;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hola C# a la antigüa");
        definirCoche();
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
