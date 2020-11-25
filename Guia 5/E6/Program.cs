using System;
using System.Collections.Generic;
using System.Linq;

namespace E6
{
    class Program
    {
        static void Main(string[] args)
        {
            string genero=" ",nombre=" ",director=" ";
            int op=1,año=0,peli=0;

            Peliteca peliteca = new Peliteca();
            List<Pelicula> peliculaAux = new List<Pelicula>();
            while(op!=0)
            {
                Console.WriteLine("Que desea hacer: ");
                Console.WriteLine("1: Buscar por genero ");
                Console.WriteLine("2: Buscar por nombre ");
                Console.WriteLine("3: Buscar por año ");
                Console.WriteLine("4: Buscar por director ");
                Console.WriteLine("5: Saber cuantas peliculas hay en total ");
                Console.WriteLine("6: Saber cuantas peliculas de un genero en especifico hay ");   

                op=Int32.Parse(Console.ReadLine());
                switch(op)
                {
                    case 1:
                        genero=Console.ReadLine();
                        peliculaAux=(peliteca.buscarGenero(genero));
                        foreach(var aux in peliculaAux)
                        {
                            Console.WriteLine(aux.Genero+" "+aux.Nombre);
                        }
                        break;
                    case 2:
                        nombre=Console.ReadLine();
                        peliculaAux=(peliteca.buscarNombre(nombre));
                        foreach(var aux in peliculaAux)
                        {
                            Console.WriteLine(aux.Nombre+" "+aux.Genero);
                        }
                        break;
                    case 3:
                        año=Int32.Parse(Console.ReadLine());
                        peliculaAux=(peliteca.buscarAño(año));
                        foreach(var aux in peliculaAux)
                        {
                            Console.WriteLine(aux.Nombre+" "+aux.Año);
                        }
                        break;
                    case 4:
                        director=Console.ReadLine();
                        peliculaAux=(peliteca.buscarDirector(director));
                        foreach(var aux in peliculaAux)
                        {
                            Console.WriteLine(aux.Nombre+" "+aux.Director);
                        }
                        break;
                    case 5:
                        peli=peliteca.cantidadPeliculas();
                        Console.WriteLine("La cantidad de peliculas son: "+peli);
                        break;
                    case 6:
                        genero=Console.ReadLine();
                        peli=peliteca.cantidadGenero(genero);
                        Console.WriteLine("La cantidad de peliculas tipo "+genero+" son: "+ peli);
                        break;
                }    
            }
        }
    }
}
