using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personenverwaltung
{
    class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public byte Alter { get; set; }
        public decimal Kontostand { get; set; }
        public bool Geschlecht { get; set; }

        public override string ToString()
        {
            if(Geschlecht)
                return Vorname + " " + Nachname + ", Männlich";
            else
                return Vorname + " " + Nachname + ", Weiblich";
        }
    }
}
