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
        }
    }
}
