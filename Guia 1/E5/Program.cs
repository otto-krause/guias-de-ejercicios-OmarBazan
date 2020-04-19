using System;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            int l1=1;
            int l2=1;
            int l3=1;
            int op=1;

            while (op!=99)           
            {
                Console.WriteLine("ingrese 3 lados de un triangulo");
                l1 = Int32.Parse(Console.ReadLine());
                l2 = Int32.Parse(Console.ReadLine());
                l3 = Int32.Parse(Console.ReadLine()); 
            
                trian lados= new trian(l1,l2,l3);

                op = Int32.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("El triangulo es escaleno? "+ lados.esEscaleno(l1, l2, l3));
                        break;
                    case 2:
                        Console.WriteLine("El triangulo es isosceles? "+ lados.esIsosceles(l1, l2, l3));
                        break;
                    case 3:
                        Console.WriteLine("El triangulo es equilatero? "+ lados.esEquilatero(l1, l2, l3));
                        break;
                }
            }
        }
    }
}