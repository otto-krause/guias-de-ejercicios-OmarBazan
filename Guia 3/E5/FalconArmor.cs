using System;
using System.Collections.Generic;

namespace E5
{
    public class FalconArmor : Armadura
    {
        int potencia=25;
        int resistencia=10;

        public int bonificacionDeDaño()
        {
            return (potencia+resistencia)/2;
        }

        public void entrenamiento(int min)
        {
            resistencia-=min;
            if(resistencia<0)
            {
                resistencia=0;
            }
            potencia+=10;
        }
    }
}