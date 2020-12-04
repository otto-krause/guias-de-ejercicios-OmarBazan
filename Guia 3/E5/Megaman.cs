using System;
using System.Collections.Generic;

namespace E5
{
    public class Megaman
    {
        int xbuster=10;
        Armadura armadura = new FalconArmor();
        public int Xbuster{ get => xbuster; set => xbuster = value; }

        public int bonificacionDaño()
        {
            return armadura.bonificacionDeDaño();
        }
        public int fuerza()
        {
            return Xbuster+armadura.bonificacionDeDaño();
        }

        public void entrenar(int min)
        {
            Xbuster+=min*2;
            armadura.entrenamiento(min);
        }

        public void cambiarArmadura()
        {
            armadura=new ShadowArmor();   
        }
    }
}