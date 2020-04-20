using System;

namespace E6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=0;
            int num2=0;
            int op=0;

            while(op!=99)        
            {
                Console.WriteLine("Ingrese dos numeros: ");
                num = Int32.Parse(Console.ReadLine());
                num2 = Int32.Parse(Console.ReadLine());
                
                operadores cuenta=new operadores(num, num2);

                Console.WriteLine("Que desea hacer? ");
                Console.WriteLine("1: fibonacci");
                Console.WriteLine("2: factorial");
                Console.WriteLine("3: mayor");
                Console.WriteLine("4: menor");
                Console.WriteLine("5: cubo");

                op = Int32.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("fibonacci: "+ cuenta.fibonacci(num));
                        break;
                    case 2:
                        Console.WriteLine("factorial: "+ cuenta.factorial(num));
                        break;
                    case 3:
                        Console.WriteLine("El mayor es: "+ cuenta.mayor(num,num2));
                        break;
                    case 4: 
                        Console.WriteLine("El menor es: "+ cuenta.menor(num,num2));
                        break;
                    case 5:
                        Console.WriteLine("El cubo es: "+ cuenta.cubo(num));
                        break;
                }
            }
        }
    }
}
