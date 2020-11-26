using System;
using System.Collections.Generic;
using System.Linq;

namespace E10
{
    public class Escuela
    {
        List<Compañeros> escuela = new List<Compañeros>();
        public Escuela()
        {
            List<string> v1 = new List<string>{"miami","argentina","mexico","dubai","eeuu"};
            List<string> v2 = new List<string>{"argentina","mexico","dubai","inglaterra","canada"};
            List<string> v3 = new List<string>{"miami","argentina","mexico"};
            List<string> v4 = new List<string>{"miami","argentina","australia","españa","eeuu"};
            List<string> v5 = new List<string>{"miami","argentina","mexico","eeuu"};
            List<string> v6 = new List<string>{"miami","mexico","dubai","eeuu"};

            Compañeros compañeros1 = new Compañeros("pepe", 250000, 5, v1 );
            Compañeros compañeros2 = new Compañeros("pepe", 300000, 3, v2);
            Compañeros compañeros3 = new Compañeros("pepe", 500000, 1, v3);
            Compañeros compañeros4 = new Compañeros("pepe", 440000, 3, v4);
            Compañeros compañeros5 = new Compañeros("pepe", 300000, 4, v5);
            Compañeros compañeros6 = new Compañeros("pepe", 150000, 3, v6);
        }

        public bool fueExitoso()
        {
            bool exito= true;
            if(dinero() && viajeros() && idiomas())
            {
                exito=true;
            }
            else
            {
                exito=false;
            }
            return exito;
        }

        public bool dinero()
        {
            int cont=0;
            foreach(Compañeros aux in escuela)
            {
                if(aux.Ganancias >200000)
                {
                    cont++;
                }
            }
            if(cont>3)
            {
                return true;
            }

            return false;
        }

        public bool viajeros()
        {
            int cont=0;
            foreach(Compañeros aux in escuela)
            {
                int cont2 = aux.Viajes.Count();
                if(cont2 > 2)
                {
                    cont++;
                }
            }
            if(cont==3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool idiomas()
        {
            int cont=0;
            bool polig=true; 
            foreach(Compañeros aux in escuela)
            {
                if(aux.Idiomas >2)
                    cont++;
                if(aux.Idiomas >5)
                    polig=true;
            }
            if(cont==2 && polig==true)
                {
                    return true;
                }
            else
                return false;
        }
    }
}