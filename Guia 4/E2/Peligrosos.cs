using System;
using System.Collections.Generic;

namespace E2
{
    public class Peligrosos : Monstruos
    {
        public Peligrosos(int respeto, string nombre) : base(respeto,nombre)
        {

        }

        public override void asustar()
        {
            Respeto+=5;
        }

        public override void reir()
        {
            Respeto+=2;
        }
    }
}