using System;
using System.Collections.Generic;
using System.Linq;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            int op=1;

            Publico lista = new Publico();
            foreach (Persona aux_p in lista.Persona_n)
                {
                    Console.WriteLine("\nLista de conocimientos de: "+aux_p.Nombre);
                    foreach (string aux in aux_p.Conocimientos)
                    {
                        Console.WriteLine(aux);
                    }
                    Console.WriteLine("\n");
                }
            while(op!=0)
            {    
                Console.WriteLine("\nQue desea hacer?");
                Console.WriteLine("1: Ver los ultimos 5 conocimientos");
                Console.WriteLine("2: Los primeros 4 conocimientos ordenados alfabeticamente");
                Console.WriteLine("3: cuantos conocimientos con terminaCION tienen");
                op = Int32.Parse(Console.ReadLine());      
                switch(op)
                {
                    case 1:
                        foreach (Persona aux_p in lista.Persona_n)
                        {
                            Console.WriteLine("\nUltimos conocimientos: "+aux_p.Nombre+"\n");
                            foreach (string aux in aux_p.obtenerLosUltimos5()) Console.WriteLine(aux);
                        }
                        break;
                    case 2:
                        foreach (Persona aux_p in lista.Persona_n)
                        {
                            Console.WriteLine("\nPrimeros 4 ordenados alfabeticamente: "+aux_p.Nombre+"\n");
                            foreach (string aux in aux_p.obtenerLosPrimeros4()) Console.WriteLine(aux);
                        }
                        break;
                    case 3:
                        foreach (Persona aux_p in lista.Persona_n)
                        {
                            Console.WriteLine("\nLos que terminaCION: "+aux_p.Nombre+"\n");
                            foreach (string aux in aux_p.terminaCION()) Console.WriteLine(aux);
                        }
                        break;
                } 
            } 
        }
    }
}