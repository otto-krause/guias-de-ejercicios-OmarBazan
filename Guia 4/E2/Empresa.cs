using System;
using System.Collections.Generic;

namespace E2
{
    public class Empresa 
    {
        List<Monstruos> monstruos = new List<Monstruos>();
        public Empresa()
        {
            Monstruos monstruos1 = new Peligrosos(55, "monstruo 1");
            Monstruos monstruos2 = new Amigables(50, "monstruo 2");
            Monstruos monstruos3 = new Peligrosos(43, "monstruo 3");
            Monstruos monstruos4 = new Amigables(20, "monstruo 4");
            monstruos.Add(monstruos1);
            monstruos.Add(monstruos2);
            monstruos.Add(monstruos3);
            monstruos.Add(monstruos4);
        }
        public void NocheDeSustos()
        {
            foreach (Monstruos aux in monstruos)
            {
                aux.asustar();
            }
        }

        public void NocheDeRisas()
        {
            foreach (Monstruos aux in monstruos)
            {
                aux.reir();
            }
        }

        public List<Monstruos> respetados()
        {
            List<Monstruos> respeto = new List<Monstruos>();
            foreach (Monstruos aux in monstruos)
            {
                if(aux.Respeto>70)
                {
                    respeto.Add(aux);
                }
            }
            return respeto;
        }

        public int EnergiaTotal()
        {
            int total=0;
            foreach (Monstruos aux in monstruos)
            {
                total+=aux.Respeto;
            }
            return total;
        }
    }
}