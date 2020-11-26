using System;
using System.Collections.Generic;
using System.Linq;

namespace E10
{
    class Program
    {
        static void Main(string[] args)
        {
            int op=1;

            Escuela escuela = new Escuela();

            while(op!=0)
            {
                Console.WriteLine("Desea saber si fue exitoso el curso?\n 1: Si\n0: No");
                op = Int32.Parse(Console.ReadLine());

                switch(op)
                {
                    case 1:
                        Console.WriteLine("Fue exitoso?: "+ escuela.fueExitoso());
                        break;
                }
            }   
        }
    }
}
