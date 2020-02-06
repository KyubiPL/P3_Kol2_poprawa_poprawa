using System;
using System.Collections.Generic;
using System.Text;

namespace P3_Kol2_poprawa_poprawa
{
    public class Hex
    {
        public string Kod { get; set; }

        public  Hex(string kod)
        {
            Kod=kod;
        }
               
        public void Deconstruct(out string R,out string G,out string B)
        {
            string[] cos = Kod.Split(',', 3);
            R = cos[0].ToString()+cos[1].ToString();
            G = cos[2].ToString() + cos[3].ToString();
            B = cos[4].ToString() + cos[5].ToString();
        }

        public void Deconstruct(out int r, out int g, out int b)
        {
            string[] cos = Kod.Split(',', 3);
            string R = cos[0].ToString() + cos[1].ToString();
            string G = cos[2].ToString() + cos[3].ToString();
            string B = cos[4].ToString() + cos[5].ToString();
             r = Convert.ToInt32(R,16);
             g = Convert.ToInt32(G,16);
             b = Convert.ToInt32(B,16);
        }

    }
}
