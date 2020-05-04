using System;
using System.Collections.Generic;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            string gen= null,dire=null,nom=null;
            int op=1,año=0;

            Peliteca peliteca = new Peliteca();
            List<Peli> peliplus = new List<Peli>();
            
            while (op!=0)
            {
                Console.WriteLine("Que desea hacer: ");
                Console.WriteLine("1: Buscar por genero ");
                Console.WriteLine("2: Buscar por nombre ");
                Console.WriteLine("3: Buscar por año ");
                Console.WriteLine("4: Buscar por director ");
                Console.WriteLine("5: Saber cuantas peliculas hay en total ");
                Console.WriteLine("6: Saber cuantas peliculas de un genero en especifico hay ");   

                op=Int32.Parse(Console.ReadLine());

                switch (op)
                { 
                    case 1:
                        Console.WriteLine("Ingrese un genero");
                        gen=Console.ReadLine();
                        peliplus=(peliteca.genero(gen));
                        foreach (var aux in peliplus)
                        {
                            Console.WriteLine(aux.Nombre+" "+aux.Genero);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ingrese un nombre");
                        nom=Console.ReadLine();
                        peliplus=peliteca.nombre(nom);
                        foreach (var aux in peliplus)
                        {
                            Console.WriteLine(aux.Nombre+" "+aux.Genero);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el año");
                        año=Int32.Parse(Console.ReadLine());
                        peliplus=peliteca.año(año);
                        foreach (var aux in peliplus)
                        {
                            Console.WriteLine(aux.Nombre+" "+aux.Año);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Ingrese el nombre del director");
                        dire=Console.ReadLine();
                        peliplus=peliteca.director(dire);
                        foreach (var aux in peliplus)
                        {
                            Console.WriteLine(aux.Nombre+" "+aux.Director);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Hay "+peliteca.cantidadTotal()+" peliculas");
                        break;
                    case 6:
                        Console.WriteLine("Ingrese un genero");
                        gen=Console.ReadLine();
                        Console.WriteLine("Hay "+peliteca.cantidadDeGenero(gen)+" peliculas del genero "+ gen);
                        break;
                }
            }
        }
    }
}
