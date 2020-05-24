using System;
using System.Collections.Generic;

namespace E2
{
    public class Plomeros : Contratistas
    {
        private int horaDeTrabajo;
        public void trabajar(int hora)
        {
            horaDeTrabajo=hora;
        }

        public int cobrar()
        {
            return (horaDeTrabajo*80);
        }
    }
}