using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M06f_OOP
{
    internal class Mensch : Lebewesen
    {
        public string Vorname { get; set; }
        public bool TrägtBrille { get; set; }

        public Mensch(string vorname, string name, string lieblingsnahrung, DateTime geburtstag, int größe, bool brille) 
            : base(name, lieblingsnahrung, geburtstag, größe)
        {
            this.Vorname = vorname;
            this.TrägtBrille = brille;
        }
    }
}
