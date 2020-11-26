using System;
using System.Collections.Generic;
using System.Linq;

namespace E9
{
    public class Matematica1
    {
        List<int> numeros = new List<int>();
        List<int> parNum= new List<int>();
        int contCincuenta=0;
        public int listaDeImpares(List<int> numero)
        {
            List<int> impares = new List<int>();
            foreach(int aux in numero)
            {
                if(aux % 2 == 1)
                {
                    impares.Add(aux);
                }
                else
                {
                    parNum.Add(aux);
                }

            }
            return impares.Count;
        }

        public int primerPar()
        {
            return parNum.First();
        }   

        public List<int> mayoresDeCincuenta(List<int> numero)
        {
            List<int> masDeCincuenta = new List<int>();
            foreach(int aux in numero)
            {
                if(aux>50)
                    masDeCincuenta.Add(aux);
            }
            contCincuenta=masDeCincuenta.Count;
            return masDeCincuenta;
        }
        public int cuantosDeCincuenta()
        {
            return contCincuenta;
        } 

        
    }
}