using System;
using System.Collections.Generic;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            int op=1,sacar=0;

            List<Empleado> empleados = new List<Empleado>();

            Empleado empleado1 = new RRHH(2000, 3);
            Empleado empleado2 = new Programador(1500, "junior");
            Empleado empleado3 = new Administrador(1500);
            Empleado empleado4 = new Programador(2500, "senior");

            empleados.Add(empleado1);
            empleados.Add(empleado2);
            empleados.Add(empleado3);
            empleados.Add(empleado4);

            while(op!=0)
            {
                Console.WriteLine("Caja bancaria\n");
                Console.WriteLine("RRHH: "+empleado1.CajaBancaria1);
                Console.WriteLine("junior: "+empleado2.CajaBancaria1);
                Console.WriteLine("administrador: "+empleado3.CajaBancaria1);
                Console.WriteLine("senior: "+empleado4.CajaBancaria1);

                Console.WriteLine("\nQue desea hacer?");
                Console.WriteLine("1: depositar");
                Console.WriteLine("2: extraer");

                op=Int32.Parse(Console.ReadLine());

                switch(op)
                {
                    case 1:
                        Console.WriteLine("Eliga al empleado que desea depositarle dinero");
                        Console.WriteLine("1: rrhh\n2: Tec.junior\n3: administrador\n4: Tec.senior");
                        op=Int32.Parse(Console.ReadLine());
                        empleados[op-1].depositar();
                        break;
                    case 2:
                        Console.WriteLine("Eliga al empleado que desea extraerle dinero");
                        Console.WriteLine("1: rrhh\n2: Tec.junior\n3: administrador\n4: Tec.senior");
                        op=Int32.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese el monto a retirar");
                        sacar=Int32.Parse(Console.ReadLine());
                        empleados[op-1].extraer(sacar);
                        break;
                    default:
                        Console.WriteLine("error");
                        op=0;
                        break;
                }
            }
        }
    }
}
