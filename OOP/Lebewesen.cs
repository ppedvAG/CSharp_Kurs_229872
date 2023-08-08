using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP
{
    internal class Lebewesen
    {
        private string name;
        public string Name
        {
            get { return name; }
            private set
            {
                //Das Schlüsselwort VALUE beschreibt in einer Set-Methode den übergebenen Wert
                if (value.Length > 0)
                    name = value;
            }
        }

        public string Lieblingsnahrung { get; set; }

        public DateTime Geburtsdatum { get; set; } 

        public int Alter
        {
            get { return ((DateTime.Now - this.Geburtsdatum).Days / 365); }
        }

        public int Größe { get; set; }

        public Lebewesen(string name, string lieblingsnahrung, DateTime geburtstag, int größe)
        {
            this.name = name;
            this.Lieblingsnahrung = lieblingsnahrung;
            this.Geburtsdatum = geburtstag;
            this.Größe = größe;
        }

        public void Wachse()
        {
            this.Größe++;
        }

        public Lebewesen ProduziereNachwuchs(string kindname)
        {
            return new Lebewesen(kindname, "Babynahrung", DateTime.Now, 30);
        }
    }
}
