﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P3_Kol2_poprawa_poprawa
{
    class Bateria : IZasilanie
    {
        int pojemnosc = 1000;
        public void Zasilaj(int energia)
        {

        }

        public void Zasilaj()
        {
            throw new NotImplementedException();
        }
    }
}
