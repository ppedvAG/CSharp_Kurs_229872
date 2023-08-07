namespace Arrays_Bedingungen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] zahlen = { 2, 4, 78, -123, -8, 0, 11111 };

            Console.WriteLine(zahlen[2]);
            zahlen[2] = 1234;
            Console.WriteLine(zahlen[2]);


            string[] worte = new string[5];


            zahlen = new int[]{ 1,2,3};
            zahlen[1] = 12;

            Console.WriteLine(zahlen.Contains(12));
            Console.WriteLine(zahlen.Contains(-34));


            string beispiel = "Hallo";
            Console.WriteLine(beispiel[2]);


            int a = int.Parse(Console.ReadLine());
            int b = 24;

            if(a == 20)
            {
                Console.WriteLine("A ist gleich 20");

                int nochNeZahl = 45;
            }
            else if(a < b)
            {
                Console.WriteLine("A ist kleiner als B");
            }
            else if(a > b)
            {
                Console.WriteLine("A ist größer als B");
            }
            else
                Console.WriteLine("A ist gleich B");

            Console.WriteLine("Ende des IF-Blocks");


            string ergebnis = (a == b) ? "A ist gleich B" : "A ist ungleich B";


            if (zahlen.Contains(12))
                Console.WriteLine("ZAHLEN enthält 12");

            string name1 = "Hans";
            string name2 = "Stefan";

            if (!name1.Equals(name2))
                Console.WriteLine("Namen sind ungleich");
            else
            { 
                Console.WriteLine("Namen sind gleich"); 
            }


        }
    }
}