using System;
using System.Collections.Generic;

namespace E5
{
    class Program 
    {
        static void Main(string[] args)
        {
            int op=1;
            string tema;

            List<string> conocimiento= new List<string>{"nadar","contar","leer","escribir","sumar","restar"};
            List<string> intereses = new List<string>{"jugar","futbol","futuro","libros","estudiar","viajar"};
            
            Humano pepe = new Humano(conocimiento,intereses,2);
            Robot walle = new Robot(conocimiento,5);
            Cyborg T800 = new Cyborg(conocimiento,intereses,7);

            while(op!=0)
            {
                Console.WriteLine("puntos de humano: "+pepe.puntos);
                Console.WriteLine("puntos de robot: "+walle.puntos);
                Console.WriteLine("puntos de cyborg: "+T800.puntos);

                Console.WriteLine("que desea hacer?");   
                Console.WriteLine("1: para que el humano estudie\n2: para que el humano pensar");
                Console.WriteLine("3: para que el robot estudie\n4: para que el robot pensar");
                Console.WriteLine("5: para que el cyborg estudie\n6: para que el cyborg pensar");
                op=Int32.Parse(Console.ReadLine());

                switch(op)
                {
                    case 1:
                        Console.WriteLine("ingrese un tema para estudiar");
                        tema = Console.ReadLine();
                        pepe.estudiar(tema);
                        break;
                    case 2:    
                        Console.WriteLine("ingrese un tema para pensar");
                        tema = Console.ReadLine();
                        pepe.pensar(tema);
                        break;
                    case 3:
                        Console.WriteLine("ingrese un tema para estudiar");
                        tema = Console.ReadLine();
                        walle.estudiar(tema);
                        break;
                    case 4:
                        Console.WriteLine("ingrese un tema para pensar");
                        tema = Console.ReadLine();
                        walle.pensar(tema);
                        break;
                    case 5:
                        Console.WriteLine("ingrese un tema para estudiar");
                        tema = Console.ReadLine();
                        T800.estudiar(tema);
                        break;
                    case 6:
                        Console.WriteLine("ingrese un tema para pensar");
                        tema = Console.ReadLine();
                        T800.pensar(tema);
                        break;
                }
            }
        }
    }
}