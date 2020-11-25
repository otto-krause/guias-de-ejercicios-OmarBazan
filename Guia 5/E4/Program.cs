using System;
using System.Collections.Generic;
using System.Linq;

namespace E2
{
    class Program
    {
        public static void Main(string[] args)
        {
            string especialidad;
            int op=1;

            Clinica clinica = new Clinica();

            while (op!=0)
            {
                Console.WriteLine("Ingrese la especialidad:  ");
                especialidad=Console.ReadLine();
                Medico medico = clinica.estaDisponible(especialidad);
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