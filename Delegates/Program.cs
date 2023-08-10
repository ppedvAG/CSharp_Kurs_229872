namespace Delegates
{
    public delegate int MeinDelegate(int zahl1, int zahl2);

    internal class Program
    {
        static void Main(string[] args)
        {
            MeinDelegate delegateVariable;

            delegateVariable = Addiere;

            int erg = delegateVariable(12, 45);
            Console.WriteLine(erg);

            delegateVariable += Addiere;
            delegateVariable += Subtrahiere;
            delegateVariable += Subtrahiere;
            delegateVariable += Subtrahiere;
            delegateVariable += Addiere;

            erg = delegateVariable(34, 12);
            Console.WriteLine(erg);

            delegateVariable -= Addiere;
            delegateVariable = Subtrahiere;

            Func<int, int, int> meinFunc = Addiere;

            FühreAus(meinFunc);
            FühreAus(Subtrahiere);


            List<string> Städteliste = new List<string>()
            {
                "München", "Hamburg", "Berlin", "Köln"
            };

            string gefundeneStadt = Städteliste.Find(SucheStadtMitH);
            Console.WriteLine(gefundeneStadt);

            gefundeneStadt = Städteliste.Find
                (
                    delegate (string stadt)
                    {
                        return stadt.StartsWith('H');
                    }
                );

            gefundeneStadt = Städteliste.Find((string stadt) => { return stadt.StartsWith('H'); });

            Predicate<string> übergebeneFunktion = stadt => stadt.StartsWith('H');
            gefundeneStadt = Städteliste.Find(übergebeneFunktion);
        }

        public static bool SucheStadtMitH(string stadt)
        {
            //return stadt.StartsWith('H');
            return stadt[1] == 'ü';
        }

        public static void FühreAus(Func<int, int, int> mehrLogik)
        {
            mehrLogik(34, 56);
        }

        public static int Addiere(int a, int b)
        {
            Console.WriteLine("ADDIERE");
            return a + b;
        }
        public static int Subtrahiere(int a, int b)
        {
            Console.WriteLine("SUBTRAHIERE");
            return a - b;
        }
    }
}