using System;
using System.Collections.Generic;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            string espec;
            int op=1;
            Clinica Medicos = new Clinica();
            
            while (op!=0)
            {
                Console.WriteLine("Ingrese la especialidad:  ");
                espec=Console.ReadLine();
                Medico medico=Medicos.estaDisponible(espec);
                if (medico!=null)
                {
                    Console.WriteLine("El medico "+medico.Nombre1+" esta disponible");
                }
                else
                {
                    Console.WriteLine("No hay medico disponible");
                }   
            }
        }
    }
}
