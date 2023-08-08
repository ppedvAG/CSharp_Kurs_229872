using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrzeugpark
{
    internal class Fahrzeug
    {
        public string Name { get; private set; }

        private int maxGeschwindigkeit;
        public int MaxGeschwindigkeit
        {
            get { return maxGeschwindigkeit; }
            set
            {
                if (value > 0)
                    maxGeschwindigkeit = value;
            }
        }


        public Fahrzeug(string name, int maxG)
        {
            this.Name = name;
            this.MaxGeschwindigkeit = maxG;
        }

        public string Info()
        {
            return $"Das Fahrzeug {this.Name} kann maximal {this.MaxGeschwindigkeit}km/h fahren";
        }
    }
}
