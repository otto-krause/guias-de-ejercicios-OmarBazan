using System;
using System.Collections.Generic;

namespace E7
{
    class Program
    {
        static void Main(string[] args)
        {
            int op=1;
            Argentina alfagor = new Argentina();

            while (op!=0)
            {
                Console.WriteLine("En que estado se encuentra el pais?");
                Console.WriteLine("1: Bajar el precio del petróleo");
                Console.WriteLine("2: Milllai habla por tv");
                Console.WriteLine("3: CoronaVairas");
                Console.WriteLine("4: Estado de inflacion");
                Console.WriteLine("5: Argentina esta default? ");

                op=Int32.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        foreach (Alfajor aux in alfagor.petroleo())
                        {
                            Console.WriteLine("Alfajor: "+aux.Nombre+" "+aux.Precio);
                        }
                        break;
                    case 2:
                        foreach (Alfajor aux in alfagor.millaiTv())
                        {
                            Console.WriteLine("Alfajor: "+aux.Nombre+" "+aux.Precio);
                        }              
                        break;
                    case 3:
                        foreach (Alfajor aux in alfagor.coronaVairas())
                        {
                            Console.WriteLine("Alfajor: "+aux.Nombre+" "+aux.Precio);
                        }               
                        break;
                    case 4:
                        Console.WriteLine(alfagor.situacionPais());
                        break;
                    case 5:
                        Console.WriteLine("Default? "+alfagor.argDefault());
                        break;
                }
            }
        }
    }
}
