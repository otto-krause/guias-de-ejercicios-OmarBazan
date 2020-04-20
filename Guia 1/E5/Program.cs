using System;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            int l1=0;
            int l2=0;
            int l3=0;
            int op=0;

            Console.WriteLine("ingrese 1 para hacer un triagunlo o 99 para salir "); 
            op = Int32.Parse(Console.ReadLine());   

            while (op!=99)           
            {

                Console.WriteLine("cateto A: ");
                l1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("cateto B: ");
                l2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Hipotenusa: ");
                l3 = Int32.Parse(Console.ReadLine()); 
  
                trian lados= new trian(l1,l2,l3);             

                Console.WriteLine("El triangulo es escaleno? "+ lados.esEscaleno(l1, l2, l3));
                Console.WriteLine("El triangulo es isosceles? "+ lados.esIsosceles(l1, l2, l3));
                Console.WriteLine("El triangulo es equilatero? "+ lados.esEquilatero(l1, l2, l3));
                Console.WriteLine("El triangulo es rectangulo? "+ lados.esTrianguloRectangulo(l1, l2, l3));

                Console.WriteLine("ingrese 1 para hacer un triagunlo o 99 para salir "); 
                op = Int32.Parse(Console.ReadLine());

            }
        }
    }
}