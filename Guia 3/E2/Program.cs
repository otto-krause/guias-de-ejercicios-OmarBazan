using System;
using System.Collections.Generic;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            int presupuesto=1,horas=0;

            while (presupuesto!=0)
            {
                Console.WriteLine("Ingrese un presupuesto y horas de trabajo para la construccion");
                presupuesto=Int32.Parse(Console.ReadLine());
                horas=Int32.Parse(Console.ReadLine());
                Construccion construccion = new Construccion(presupuesto,horas);
                Console.WriteLine("Es posible la construccion? "+construccion.permiso(presupuesto));
            }
        }
    }
}
