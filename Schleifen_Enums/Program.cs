namespace Schleifen_Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 10;

            while (a < b)
            {
                Console.WriteLine("Schleife läuft " + a);
                a++;

                if (a == 5)
                    break;
            }

            Console.WriteLine("Schleife ENDE");

            a = 5;

            do
            {
                a--;
                Console.WriteLine(a);
            } while (a > 0);
            Console.WriteLine("Schleife ENDE");


            for (int i = 0; i < 10; i += 2)
            {
                Console.WriteLine("Schleife läuft");
                Console.WriteLine($"Schleifendurchlauf Nr. {i + 1}");

                i++;
            }

            int[] zahlen = { 2, 5, 12, 56, 78, -123 };
            for (int i = 0; i < zahlen.Length; i++)
            {
                Console.WriteLine(zahlen[i]);
            }

            foreach (var item in zahlen)
            {
                Console.WriteLine(item);
            }

            Wochentag heutigerTag = Wochentag.Montag;
            Console.WriteLine($"Heute ist {heutigerTag}.");

            Console.WriteLine("Welcher Wochentag ist dein Lieblingstag?");
            for (int i = 1; i <= Enum.GetValues(typeof(Wochentag)).Length; i++)
            {
                Console.WriteLine($"{i}: {(Wochentag)i}");
            }
            heutigerTag = (Wochentag)int.Parse(Console.ReadLine());

            Console.WriteLine($"Dein Lieblingstag ist {heutigerTag}.");


            if (Console.ReadKey(true).Key == ConsoleKey.M)
                Console.WriteLine("Du hast M gedrückt");

            switch (heutigerTag)
            {
                case Wochentag.Montag:
                    Console.WriteLine("Wochenstart");
                    break;
                case Wochentag.Dienstag: 
                case Wochentag.Mittwoch:
                case Wochentag.Donnerstag:
                    Console.WriteLine("Arbeitstag");
                    break;
                case Wochentag.Freitag:
                case Wochentag.Samstag:
                case Wochentag.Sonntag:
                    Console.WriteLine("Wochenende");
                    break;
                default:
                    break;
            }
        }
    }

    enum Wochentag { Montag = 1, Dienstag, Mittwoch, Donnerstag, Freitag, Samstag, Sonntag}
}