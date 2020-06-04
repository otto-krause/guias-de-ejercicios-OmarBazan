using System;
using System.Collections.Generic;

namespace E2
{
    public class Amigables : Monstruos
    {
        public Amigables(int respeto, string nombre) : base(respeto,nombre)
        {

        }

        public override void asustar()
        {
            Respeto+=7;
        }

        public override void reir()
        {
            Respeto+=1;
        }
    }
}