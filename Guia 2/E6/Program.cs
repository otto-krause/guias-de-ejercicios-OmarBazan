using System;
using System.Collections.Generic;

namespace E6
{
    class Program
    {
        static void Main(string[] args)
        {
            Steam st = new Steam();
            int op=1;
            string gen=null,calif=null;

            while (op!=0)
            {
                Console.WriteLine("1: Buscar por genero");
                Console.WriteLine("2: Buscar por calificacion");

                op=Int32.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Ingrese el genero");
                        gen=Console.ReadLine();
                        foreach (Juego aux in st.porGenero(gen))
                        {
                            Console.WriteLine("Juego: "+aux.Titulo);
                        }                       
                        break;
                    case 2:
                        Console.WriteLine("Ingrese la calificacion");
                        calif=Console.ReadLine();
                        foreach (Juego aux in st.porCalificacion(calif))
                        {
                            Console.WriteLine("Juego: "+aux.Titulo);
                        }
                        break;
                }
            }
        }
    }
}
