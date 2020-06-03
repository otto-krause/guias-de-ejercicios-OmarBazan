using System;
using System.Collections.Generic;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int op=1;

            Perro perro = new Perro(30);
            Pajaro pajaro = new Pajaro(50);

            while (op!=0)
            {
                Console.WriteLine("1: Para dar de comer al perro \n2: Para dar de comer al pajaro");
                Console.WriteLine("3: Para que juegue el perro \n4: Para que juegue el pajaro");
                Console.WriteLine("5: Para que duerma el perro \n6: Para que duerma el pajaro");
                op = Int32.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        perro.come();
                        Console.WriteLine("Energia del perro: " + perro.energy());
                        break;
                    case 2:
                        pajaro.come();
                        Console.WriteLine("Energia del loro: "+pajaro.energy());
                        break;
                    case 3:
                        perro.juega();
                        Console.WriteLine("Energia del loro: "+perro.energy());
                        break;
                    case 4:
                        pajaro.juega();
                        Console.WriteLine("Energia del loro: "+pajaro.energy());
                        break;
                    case 5:
                        perro.dormir();
                        Console.WriteLine("Energia del loro: "+perro.energy());
                        break;
                    case 6:
                        pajaro.dormir();
                        Console.WriteLine("Energia del loro: "+pajaro.energy());
                        break;
                }
            }
        }
    }
}
