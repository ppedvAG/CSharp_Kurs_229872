using M06f_OOP;

namespace GenerischeListen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklaration und Initialisierung einer Liste von Strings
            System.Collections.Generic.List<string> Städteliste = new List<string>()
            {
                "Nürnberg",
                "Dortmund",
                "Bielefeld"
            };

            //Hinzufügen von Listeneinträgen
            Städteliste.Add("Hamburg");
            Städteliste.Add("Berlin");
            Städteliste.Add("München");
            Städteliste.Add("Köln");
            Städteliste.Add("Düsseldorf");

            //Ausgabe der Länge der Liste
            Console.WriteLine(Städteliste.Count);

            //Ausgabe der 4. Listenposition
            Console.WriteLine(Städteliste[3]);

            //Manipulation der 4. Listenposition
            Städteliste[3] = "Dresden";
            Console.WriteLine(Städteliste[3]);

            //Schleife über die Liste
            foreach (var item in Städteliste)
            {
                Console.WriteLine(item);
            }

            //Löschen des Eintrags 'Köln' (Nachfolgende Einträge rücken nach oben)
            Städteliste.Remove("Köln");

            //Beispielliste mit Lebewesen
            List<Lebewesen> lebewesenListe = new List<Lebewesen>();
            lebewesenListe.Add(new Mensch("Anna", "Meier", "Lasagne", new DateTime(1984, 5, 6), 189, false));
            lebewesenListe.Add(new Mensch("Rainer", "Zufall", "Lasagne", new DateTime(1984, 5, 6), 189, true));
            Console.WriteLine(lebewesenListe[1].Name);

            //Deklaration und Initialisierung eines Dictionarys (Key: String, Value: Int)
            Dictionary<string, int> Dict = new Dictionary<string, int>();

            //Hinzufügen von Dictionary-Einträgen
            Dict.Add("Hallo", 456);
            Dict.Add("Ahoj", 5);
            Dict.Add("Ciao", -78);
            Dict.Add("Moin", 456);

            //Ausgabe des Eintrags mit Key 'Ciao'
            Console.WriteLine(Dict["Ciao"]);
        }
    }
}
