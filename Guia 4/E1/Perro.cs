using System;
using System.Collections.Generic;

namespace E1
{
    public class Perro : Animal
    {

        public Perro(int energia) : base(energia)
        {

        }

        public override void come()
        {
            Energia+=15;
        }
        public override void juega()
        {
            Energia-=20;
        }
    }
}