namespace Fahrzeugpark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fahrzeug fahrzeug1 = new Fahrzeug("BMW", 250);
            Fahrzeug fahrzeug2 = new Fahrzeug("Audi", 230);

            Console.WriteLine($"Fahrzeug1 heißt {fahrzeug1.Name}.");
            Console.WriteLine(fahrzeug1.MaxGeschwindigkeit);
            fahrzeug1.MaxGeschwindigkeit = 300;
            Console.WriteLine(fahrzeug1.MaxGeschwindigkeit);

            Console.WriteLine(fahrzeug1.Info());
            Console.WriteLine(fahrzeug2.Info());

        }
    }
}