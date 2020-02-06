using System;
using System.Collections.Generic;
using System.Text;

namespace P3_Kol2_poprawa_poprawa
{
    public class Skladnik
    {
        int Weglowodany { get; set; }
        int Tluszcz { get; set; }
        int Sol { get; set; }

        public Skladnik(int Weglowodany,int Tluszcz,int Sol)
        {
            this.Weglowodany = Weglowodany;
            this.Tluszcz = Tluszcz;
            this.Sol = Sol;
        }

    }
}
