using System;
using System.Collections.Generic;
using System.Linq;

namespace E8
{
    public class Matematicas2
    {
        List<int> numeros = new List<int>();
        List<int> primolist = new List<int>();
        public List<int> Primos(List<int> numeros)//NUMEROS PRIMOS
        {
            List<int> primo = new List<int>();
            foreach(int aux in numeros)
            {
                bool esPrimo = true;
                for (int i = 2; i < aux; i++) 
                {
                    if( aux % i == 0)
                    {
                        esPrimo = false;
                    }
                }       
                if(esPrimo)
                {
                    primo.Add(aux);
                    primolist.Add(aux);
                }
            }
            primo.Remove(1);
            primolist.Remove(1);
            return primo;
        }

        public List<int> Pares(List<int> numero)//NUMEROS PARES
        {
            List<int> par = new List<int>();
            foreach(int aux in numero)
            {
               if(aux % 2 == 0)
               {
                    par.Add(aux);
               }
            }
            return par;
        }

        public List<int> Aplanar(List<int> numero)//APLANAR
        {
            List<int> sinRepetir = numero.Distinct()
            .ToList();
            List<int> pan = sinRepetir;
            return sinRepetir;
        }

        public int Suma(List<int> numeros)//SUMA DE TODOS LOS NUMEROS
        {
            int total = numeros.Sum();
            return total;
        }

        public int sumaDePrimos()//SUMA DE NUMEROS PRIMOS
        {
            int total = primolist.Sum();
            return total;
        }

        public int Maximo(List<int> numeros)//MAXIMO NUMERO
        {
            int maxi = numeros.Max();
            return maxi;
        }

        public int Minimo(List<int> numeros)//MINIMO NUMERO
        {
            int mini = numeros.Min();
            return mini;
        }
    }
}