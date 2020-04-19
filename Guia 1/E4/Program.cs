using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            int min=0;
            int op=0;

            gatito michi= new gatito("michi",true,50);
            
            while (op!=99)
            {
                Console.WriteLine("Elija un opcion que quiera saber ");
                Console.WriteLine("1= nombre");
                Console.WriteLine("2= estaVacunado");
                Console.WriteLine("3= jugar");
                Console.WriteLine("4= comer");
                Console.WriteLine("5= estaSaludable");
                op = Int32.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("El nombre del gatito? "+ michi.nombreDelGatito());
                        break;
                    case 2:
                        Console.WriteLine("Esta vacunado? "+ michi.estaVacunado());
                        break;
                    case 3:
                        Console.WriteLine("ingrese minutos jugados: ");
                        min = Int32.Parse(Console.ReadLine());
                        michi.accionJugar(min);
                        break;
                    case 4:
                        michi.comer();
                        break;
                    case 5:
                        Console.WriteLine("El gatito esta saludable? /n"+ michi.estaSaludable()); 
                        break;
                }
            }    
        }
    }
}
