using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Znamky
{
    public class Vysvedceni
    {
        public string Jmeno;
        public DateTime Datum;
        public float PrumZnamka;
        public string Prospech;
        public Predmet Predmety;

        public Vysvedceni(string jmeno, DateTime datum, float prumZnamka, string prospech, string predmet)
        {
            Jmeno = jmeno;
            Datum = datum;
            PrumZnamka = prumZnamka;
            Prospech = prospech;
            Predmety = predmet;
        }       
    }
}
