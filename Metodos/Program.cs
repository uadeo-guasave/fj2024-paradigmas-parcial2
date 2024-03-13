using Metodos;

// definir un objeto de tipo Libro
var libro1 = new Libro();
Console.WriteLine("Id de {0}: {1}", nameof(libro1), libro1.Id);

// imprimir el título
Console.WriteLine("Titulo: {0}", libro1.Titulo);


// definir un segundo libro con titulo al inicializar
var libro2 = new Libro("C# OOP");

// definir un tercer libro con titulo y año al inicializar
var libro3 = new Libro("F# FP", 2024);
