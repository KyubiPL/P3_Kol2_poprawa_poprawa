using System;
using System.Collections.Generic;
using System.Text;

using System.Linq;

namespace P3_Kol2_poprawa_poprawa
{
    public static class Extension
    {
        public static string licz(this string tekst,int ileZnakow )
        {
            string tak = null;
            char[] cos= tekst.ToCharArray();
            int ile = tekst.Count();
            if (ile < 3)
                return "za krotki tekst";
            if(ile>ileZnakow)
            {
                for (int i = 1; i <4; i++)
                {
                    cos[ileZnakow + i] = '.';
                }
             
                for (int i=ileZnakow+3;i<cos.GetLength(0);i++)
                {
                    cos[i] ='\0' ;
                }
                 tak = new string(cos);
                
            }
            return tak;


        }
    }
}
