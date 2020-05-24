using System;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int op=1;
            
            Homero homero = new Homero(2);
            Lenny lenny = new Lenny();
            Pato pato = new Pato();
            Mrburns burns = new Mrburns();
            Planta planta = new Planta(10001, homero, burns);

            while(op!=0)
            {
                Console.WriteLine("Eliga una opcion: ");
                Console.WriteLine("1: La planta esta en peligro?");    
                Console.WriteLine("2: Homero compra donas");
                Console.WriteLine("3: Homero come dona");
                Console.WriteLine("4: Lenny toma cerveza");
                Console.WriteLine("5: Cambiar empleado por Homero");
                Console.WriteLine("6: Cambiar empleado por Lenny");
                Console.WriteLine("7: Cambiar empleado por Pato");
                Console.WriteLine("8: Despojar a burns de sus riquezas");

                op = Int32.Parse(Console.ReadLine());
                
                switch (op)
                {
                    case 1:
                        Console.WriteLine(planta.estaEnPeligro());
                        break;
                    case 2:
                        homero.compra();
                        break;
                    case 3: 
                        homero.come();
                        break;
                    case 4:
                        lenny.toma();
                        break;
                    case 5:
                        planta.cambiarEmpleado(homero);
                        break;
                    case 6:
                        planta.cambiarEmpleado(lenny);
                        break;
                    case 7:
                        planta.cambiarEmpleado(pato);
                        break;
                    case 8:
                        burns.despojarRiquezas();
                        break;
                }
           }
        }
    }
}
