using System;
using System.Collections.Generic;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            string turno;
            
            Console.WriteLine("Para poder consultar un turno ingrese la especialidad:  ");
            turno=Console.ReadLine();

            Clinica Medicos = new Clinica();

            foreach (string aux in Medicos.ListDr)
            {
                if (turno==aux.Especialidad)
                {
                    Console.WriteLine(Medicos.EstaDisponible());
                }
            }
        }
    }
}
