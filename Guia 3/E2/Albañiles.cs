using System;
using System.Collections.Generic;

namespace E2
{
    public class Albañiles : Contratistas
    {
        int edad;
        bool tituloMMO;
        int horaDeTrabajo;

        public Albañiles(int edad, bool tituloMMO)
        {
            this.edad = edad;
            this.tituloMMO = tituloMMO;
        }

        public void trabajar(int hora)
        {
            horaDeTrabajo=hora;
        }

        public int cobrar()
        { 
            int mmo=0;
            if (tituloMMO==true)
            {   
                mmo=50;
            }
            if ((edad>=20)&&(edad<30))
            {
                return horaDeTrabajo*50+mmo;//5000, 5050, 9000, 9050, 12050
            }
            else
            {
                if ((edad>=30)&&(edad<50))
                {
                    return horaDeTrabajo*90+mmo;
                }
                else
                {
                    return horaDeTrabajo*120+mmo;
                }
            }
        }
    }
}