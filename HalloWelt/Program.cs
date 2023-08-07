namespace HalloWelt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Heute ist Montag.");

            int Alter;

            Alter = 35;

            string Stadt = "Berlin";

            Console.WriteLine(Stadt);
            Console.WriteLine(Alter);

            int DoppeltesAlter = Alter * 2;

            Alter = 40;

            char Textzeichen = 'A';

            double Kosten = 45.89;
            Console.WriteLine(Kosten);

            bool Wahrheitswert = true;

            string Satz = "Ich bin " + Alter.ToString() + " Jahre alt und wohne in " + Stadt + ".";
            Console.WriteLine(Satz);
            Console.WriteLine("Ich bin " + Alter.ToString() + " Jahre alt und wohne in " + Stadt + ".");

            Satz = $"Ich bin {Alter} Jahre alt und wohne in {Stadt}.";
            Console.WriteLine(Satz);
            Console.WriteLine($"Ich bin {Alter} Jahre alt und wohne in {Stadt}.");

            Console.WriteLine("Ich bin {0} Jahre alt und wohne in {1}.", Alter, Stadt);


            int a = 45;
            int b = 67;
            Console.WriteLine($"{a} + {b} = {a + b}");


            string bsp = "Dies ist ein \tTabulator und dies ist ein\nZeilenumbruch";
            Console.WriteLine(bsp);

            string path = "\"C:\\Programme\\MeinProgramm.exe\"";
            Console.WriteLine(path);

            string verbatim = @"Dies ist ein    Tabulator und dies ist ein
Zeilenumbruch";
            Console.WriteLine(verbatim);

            Console.WriteLine("Bitte gib deinen Namen ein:");
            string eingabe = Console.ReadLine();

            Console.WriteLine($"Du heißt also {eingabe}.");

            int zahl;
            eingabe = Console.ReadLine();
            zahl = int.Parse(eingabe);

            int produkt = zahl * 2;
            Console.WriteLine($"Ergebnis: {produkt}");


            int intZahl = 345;
            double doubleZahl = intZahl;

            doubleZahl = 75.834;
            intZahl = (int)doubleZahl;

            Console.WriteLine(intZahl);


            double x = 0;
            double y = 100;

            Console.WriteLine(y/x);
        }
    }
}