using System;
using System.Collections.Generic;

namespace E2
{
    public class Pintores : Contratistas
    {
        private int ltsDePintura;
        private int horasDeTrabajo;
        public Pintores()
        {
            this.ltsDePintura = 3;
        }

        public void trabajar(int hora)
        {
            horasDeTrabajo=hora;
        }

        public int cobrar()
        {
            return (horasDeTrabajo*ltsDePintura)*50;
        }
    }//100 hs
}//7500, 40000, 40150