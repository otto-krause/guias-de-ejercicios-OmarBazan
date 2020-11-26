using System;
using System.Collections.Generic;
using System.Linq;

namespace E9
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=1;

            Matematica1 matematica = new Matematica1();

            List<int> listAux = new List<int>();

            while(numero!=0)
            {
                Console.WriteLine("ingrese un numero, para finalizar ingrese 0");
                numero = Int32.Parse(Console.ReadLine());
                listAux.Add(numero);
            }
            listAux.Remove(0);

            Console.WriteLine("Lista de numeros");
            foreach(var i in listAux) Console.WriteLine(i);
            
            Console.WriteLine("Cantidad de impares");
             Console.WriteLine(matematica.listaDeImpares(listAux));
            
            Console.WriteLine("Primer numero par");
            Console.WriteLine(matematica.primerPar());

            Console.WriteLine("Numeros mayores de 50");
            foreach(var i in matematica.mayoresDeCincuenta(listAux)) Console.WriteLine(i);

            Console.WriteLine("Mayores de 50");
            Console.WriteLine(matematica.cuantosDeCincuenta());
        }
    }
}
