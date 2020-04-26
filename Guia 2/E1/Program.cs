using System;
using System.Collections.Generic;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=1;
            int cont=0;
            int prim=0;
            int ulti=0;

            List<int> ListaNumeros = new List<int>();

            while (num!=0)
            {
                Console.WriteLine("ingrese un numero: ");
                num = Int32.Parse(Console.ReadLine());
                ListaNumeros.Add(num);
                
            }
            
            ListaNumeros.Remove(0);
            prim=ListaNumeros[0];
            ulti=ListaNumeros[ListaNumeros.Count-1];

            foreach (int aux in ListaNumeros)
            {
                Console.WriteLine("Numero: "+ aux);
                cont= aux>50 ? cont+1 : cont+0;
            }

            Console.WriteLine("Se ingresaron: "+ListaNumeros.Count+" numeros");
            Console.WriteLine("El primer numero es "+prim);
            Console.WriteLine("El ultimo numero es "+ulti);            
            Console.WriteLine("Hay "+ cont+" de numero mayores a 50");
        }
    }
}
