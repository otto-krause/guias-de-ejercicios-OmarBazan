using System;
using System.Collections.Generic;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, posicion, pais;
            int numDeFig=0,op=1;   

            Album fi = new Album();

            while(op!=0)
            {
                Console.WriteLine("Que desea hacer: ");
                Console.WriteLine("1: Agregar figuritas");
                Console.WriteLine("2: Cantidad de delanteros");
                Console.WriteLine("3: Cantidad de mediocampistas");
                Console.WriteLine("4: Saber si el album esta completo");
                op=Int32.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Ingrese nombre, posicion, pais y numero de figurita");
                        nombre=Console.ReadLine();
                        posicion=Console.ReadLine();
                        pais=Console.ReadLine();
                        numDeFig=Int32.Parse(Console.ReadLine());
                        Figuritas figu = new Figuritas(nombre,posicion,pais,numDeFig);
                        fi.Agregar(figu);
                        break;
                    case 2:
                        Console.WriteLine("Hay "+fi.CuantosDelanteros()+" delantero/s");
                        break;
                    case 3:
                        Console.WriteLine("Hay "+fi.CuantosMediocampistas()+" mediocampista/s");
                        break;
                    case 4:
                        Console.WriteLine("Esta completo? "+fi.EstaCompleto());
                        break;
                }
            }
        }
    }
}
