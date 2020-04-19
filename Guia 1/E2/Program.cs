using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
             int num = 0;
            int num2 = 0;
            int multi = 0;
            int divi = 0;
            Console.WriteLine("ingrese un numero: ");
            num = Int32.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro numero: ");
            num2 = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < num2; i++)
            {
                multi=multi+num;                
            }
            Console.WriteLine("el producto es: "+multi);
            while(num>=num2)
            {
                num=num-num2;
                divi++;
            }
            Console.WriteLine("la division es: "+divi);
            Console.WriteLine("el cosciente es: "+num);
        }
    }
}
