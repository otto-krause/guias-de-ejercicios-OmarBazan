using System;
using System.Collections.Generic;

namespace E1
{
    public class Pajaro : Animal
    {

        public Pajaro(int energia) : base(energia)
        {
            
        }

        public override void come()
        {
            Energia+=10;
        }
        public override void juega()
        {
            Energia-=5;
        }
    }
}