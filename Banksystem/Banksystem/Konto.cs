using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banksystem
{
    public class Konto
    {
        public Konto(decimal startwert)
        {
            Kontostand = startwert;
        }

        public string Username { get; set; }
        public string Passwort { get; set; }
        public decimal Kontostand { get; set; }

        public void Einzahlen(decimal betrag)
        {
            Kontostand += betrag;
        }
        public void Abheben(decimal betrag)
        {
            Kontostand -= betrag;
        }
    }
}
