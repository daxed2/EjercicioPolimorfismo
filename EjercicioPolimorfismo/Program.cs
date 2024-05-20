// Polimorfismo mediante Listas
using EjercicioPolimorfismo;

List<Gato> gatoLista = new List<Gato>();
string opcion = "";
do
{
    Gato gato = new Gato();
    Console.WriteLine("Ingrese el nombre del Gato:");
    gato.Nombre = Console.ReadLine();
    gatoLista.Add(gato);
    Console.WriteLine("Desea continuar? (S/N)");
    opcion = Console.ReadLine();
} while (opcion != "N");

Console.WriteLine("\n\n********** Lista de Gatos **********");
foreach (Gato e in gatoLista)
{
    e.Correr();
}
Console.WriteLine("********* Fin Lista de Gatos **********");


//Polimorfismo mediante herencia y sobrecarga
Console.WriteLine("\n\n********** Objeto Jaguar **********");
Jaguar jaguar = new Jaguar();
jaguar.TipoAnimal = "Jaguar";
jaguar.Velocidad = 35;
jaguar.Correr();
jaguar.Correr("Jaguarcito");
Console.WriteLine("********** Fin Objeto Jaguar **********");

Console.WriteLine("\n\n********** Objeto Leopardo **********");
Leopardo leopardo = new Leopardo();
leopardo.TipoAnimal = "LeoPardo";
leopardo.Velocidad = 25;
leopardo.Correr();
leopardo.Correr("Lenoradito");
Console.WriteLine("********** Fin Objeto Leopardo **********");