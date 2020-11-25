using System;
using System.Collections.Generic;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            string titulo, autor;
            int op=1;
            List<Libro> leidos = new List<Libro>();
            Tragalibros tragalibros1 =new Tragalibros("Paula", 21, leidos);

            while(op!=0)
            {
                Console.WriteLine("1: Leer");
                Console.WriteLine("2: Calcular ci");

                op=Int32.Parse(Console.ReadLine());
                
                switch(op)
                {
                    case 1:
                        Console.WriteLine("ingrese titulo y autor");
                        titulo=Console.ReadLine();
                        autor=Console.ReadLine();
                        Libro Lib= new Libro(titulo,autor);
                        tragalibros1.leido(Lib);
                        break;
                    case 2:
                        Console.WriteLine("El ci de "+ tragalibros1.Nombre+" es de "+tragalibros1.Ci(leidos));
                        break;
                }
            }
        }
    }
}
