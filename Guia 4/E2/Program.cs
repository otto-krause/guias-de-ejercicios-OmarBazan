using System;
using System.Collections.Generic;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            int op=1;
            Empresa empresa = new Empresa();
            
            while (op!=0)
            {
                Console.WriteLine("1: Para la noche de sustos \n2: Para la noche de risas");
                Console.WriteLine("3: Para mostrar los mas respetados");
                Console.WriteLine("4: Para ver la energia que genero la empresa");
                op = Int32.Parse(Console.ReadLine());

                switch(op)
                {
                    case 1:
                        empresa.NocheDeSustos();
                        break;
                    case 2:
                        empresa.NocheDeRisas();
                        break;
                    case 3:
                        foreach (Monstruos aux in empresa.respetados())
                        {
                            Console.WriteLine(aux.Nombre +" "+ aux.Respeto);
                        }
                        break;
                    case 4:
                        Console.WriteLine("La energia total recaudada es: "+empresa.EnergiaTotal());
                        break;
                }
            }
        }
    }
}
