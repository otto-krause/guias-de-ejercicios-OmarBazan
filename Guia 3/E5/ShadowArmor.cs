using System;
using System.Collections.Generic;

namespace E5
{
    public class ShadowArmor : Armadura
    {
        int degaste=1;
        Megaman xbuster= new Megaman();

        public void entrenamiento(int min)
        {
            degaste+=xbuster.Xbuster;
        }

        public int bonificacionDeDaño()
        {
            return 80/degaste;
        }
    }
}