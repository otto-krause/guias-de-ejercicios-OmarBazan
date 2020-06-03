using System;
using System.Collections.Generic;

namespace E1
{
    public abstract class Animal
    {
        int energia;

        public int Energia { get => energia; set => energia = value; }

        public Animal(int energia)
        {
            this.energia = energia;
        }

        public abstract void come();

        public abstract void juega();

        public void dormir()
        {
            energia=100;
        }
        
        public int energy()
        {
            return energia;
        }
    }
}