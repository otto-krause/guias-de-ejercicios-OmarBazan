using System;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=0;
            Console.WriteLine("ingrese un numero");
            num=Int32.Parse(Console.ReadLine());
            Console.WriteLine(par(num));
            primo(num);
        }
        void par(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("el numero es par");
            }
        }
        void primo(int num)
        {
            int cont=0;
            for (int i=1; i<=num; i++)
            {
                if(num%i==0)
                {
                    cont++;
                }
            }
            if(cont<2)
            {
                Console.WriteLine("el numero es primo");
            }
        }
    }
}
