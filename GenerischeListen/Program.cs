using Fahrzeugpark;
using Lab06f_Fahrzeugpark;

namespace GenerischeListen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> Städteliste = new List<string>()
            {
                "Berlin",
                "Hamburg",
                "München"
            };

            Städteliste.Add("Düsseldorf");
            Städteliste.Add("Köln");
            Städteliste.Add("Nürnberg");

            Console.WriteLine(Städteliste.Count);

            Console.WriteLine(Städteliste[2]);
            Städteliste[4] = "Bielefeld";

            foreach (var item in Städteliste)
            {
                Console.WriteLine(item);
            }

            Städteliste.Remove("München");


            List<Fahrzeug> fahrzeuge = new List<Fahrzeug>()
            {
                new PKW("BMW", 250, 23000, 5),
                Fahrzeug.GeneriereFahrzeug()
            };


            Dictionary<string, int>Dict = new Dictionary<string, int>();
            Dict.Add("Hallo", 456);
            Dict.Add("Ahoj", -12);
            Dict.Add("Moin", 0);
            Dict.Add("Ciao", 99999);

            Console.WriteLine(Dict["Moin"]);
        }
    }
}