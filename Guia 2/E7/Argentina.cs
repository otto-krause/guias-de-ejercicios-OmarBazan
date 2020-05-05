using System;
using System.Collections.Generic;

namespace E7
{
    public class Argentina
    {
        List<Alfajor> Alfajores = new List<Alfajor>();

        public Argentina()
        {
            Alfajor alf1 = new Alfajor("tortoreo",40,"oreo");
            Alfajor alf2 = new Alfajor("chajaja",75,"aguila");    
            Alfajor alf3 = new Alfajor("ladrillo",60,"waymayen");

            Alfajores.Add(alf1);
            Alfajores.Add(alf2);
            Alfajores.Add(alf3);
        }

        public List<Alfajor> petroleo()
        {
            List<Alfajor> infla = new List<Alfajor>(); 
            foreach (Alfajor aux in Alfajores)
            {
                aux.Precio+=80;
                infla.Add(aux);
            }
            return infla;
        }   

        public List<Alfajor> millaiTv()
        {
            List<Alfajor> infla = new List<Alfajor>(); 
            foreach (Alfajor aux in Alfajores)
            {
                aux.Precio=aux.Precio*2;
                infla.Add(aux);
            }
            return infla;
        }

        public List<Alfajor> coronaVairas()
        {
            List<Alfajor> infla = new List<Alfajor>(); 
            foreach (Alfajor aux in Alfajores)
            {
                if (aux.Empresa!="waymayen")
                {
                    aux.Precio+=1000;
                    infla.Add(aux);   
                }
                else
                {
                    infla.Add(aux);
                }
            }
            return infla;
        }

        public int total()
        {
            int acu=0;
            foreach (Alfajor aux in Alfajores)
            {
                acu+=aux.Precio;
            }
            return acu;
        }

        public string situacionPais()
        { 
            string sit=null;
            if (total()>1000)
            {
                sit="El estado del pais es: hiperinflacion";
            }
            else
            {
                if ((total()<1000)&&(total()>500))
                {
                    sit="El estado del pais es: super";
                }
                else
                {
                    sit="El estado del pais es: normal";   
                }
            }     
            return sit;
        }

        public bool argDefault()
        {
            return (total()>1000);
        }
    }
}