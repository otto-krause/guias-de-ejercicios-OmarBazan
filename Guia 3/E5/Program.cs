using System;
using System.Collections.Generic;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            int op=1,min=0;

            Megaman x = new Megaman();

            while(op!=0)
            {
                Console.WriteLine("que desea hacer?");
                Console.WriteLine("1: Conocer la bonificacion de daño");
                Console.WriteLine("2: Realizar entrenamiento");
                Console.WriteLine("3: Conocer la fuerza");
                Console.WriteLine("4: Cambiar armadura a shadow armor");

                op=Int32.Parse(Console.ReadLine());

                switch(op)
                {
                    case 1:
                        Console.WriteLine("la bonificacion de daño es de "+x.bonificacionDaño());
                        break;
                    case 2:
                        Console.WriteLine("Ingrese los minutos de entrenamiento ");
                        min=Int32.Parse(Console.ReadLine());
                        x.entrenar(min);
                        Console.WriteLine(x.Xbuster);
                        break;
                    case 3:
                        Console.WriteLine("la fuerza de megaman es de "+x.fuerza());
                        break;
                    case 4:
                        x.cambiarArmadura();
                        Console.WriteLine("Shadow Armor equipada");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
        }
    }
}
