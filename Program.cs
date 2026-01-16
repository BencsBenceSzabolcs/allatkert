using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace allatkert
{
    internal class Program
    {
        public class Allat
        {
            public string Nev;
            public string Faj;
            public int SzuletesiEv;
            public string Elohely;

            public Allat(string nev, string faj, int szuletesiEv, string elohely)
            {
                Nev = nev;
                Faj = faj;
                SzuletesiEv = szuletesiEv;
                Elohely = elohely;
            }

            public override string ToString()
            {
                return "Az allat neve:" + Nev + ", faja:" + Faj + "Születési éve:" + SzuletesiEv + ", élőhelye:" + Elohely;
            }

            public int hanyeves()
            {
                return 2026 - SzuletesiEv;
            }
        }
        static void Main(string[] args)
        {
            List<Allat> allatok = new List<Allat>();
            allatok.Add(new Allat("Leo", "Oroszlán", 2015, "Dzsungel"));
            allatok.Add(new Allat("Molly", "Elefánt", 2010, "Esőerdő"));
            allatok.Add(new Allat("Lajos", "Pingvin", 2018, "Jégmezők"));
            allatok.Add(new Allat("Zazu", "Zebra", 2012, "Szavanna"));
            allatok.Add(new Allat("Luna", "Tigris", 2014, "Erdő"));
        }
    }
}
