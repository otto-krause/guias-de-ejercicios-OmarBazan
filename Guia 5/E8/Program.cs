using System;
using System.Collections.Generic;
using System.Linq;

namespace E8
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=1;
            
            Matematicas2 mate = new Matematicas2(); 
            List<int> listAux = new List<int>(); 
            
            while(numero!=0)
            {
                Console.WriteLine("ingrese un numero, para finalizar ingrese 0");
                numero= Int32.Parse(Console.ReadLine());
                listAux.Add(numero); 
            }
            listAux.Remove(0);
            
            Console.WriteLine("NUMEROS PRIMOS");  
            foreach(var i in mate.Primos(listAux)) Console.WriteLine(i+" es primo"); 
            
            Console.WriteLine("NUMEROS PARES");
            foreach(var i in mate.Pares(listAux)) Console.WriteLine(i+" es par");
            
            Console.WriteLine("NUMEROS APLANAR");
            foreach(var i in mate.Aplanar(listAux)) Console.WriteLine(i);
            
            Console.WriteLine("SUMA DE TODOS LOS NUMEROS :"+mate.Suma(listAux));
            
            Console.WriteLine("SUMA DE TODOS LOS NUMEROS PRIMOS :"+mate.sumaDePrimos());
            
            Console.WriteLine("NUMERO MAXIMO :"+mate.Maximo(listAux));
            
            Console.WriteLine("NUMERO MINIMO :"+mate.Minimo(listAux));
        }
    }
}