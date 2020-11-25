using System;
using System.Collections.Generic;
using System.Linq;

namespace E6
{
    public class Pelicula
    {
        string nombre;
        string genero;
        int año;
        string director;

        public Pelicula(string nombre, string genero, int año, string director)
        {
            this.nombre = nombre;
            this.genero = genero;
            this.año = año;
            this.director = director;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Genero { get => genero; set => genero = value; }
        public int Año { get => año; set => año = value; }
        public string Director { get => director; set => director = value; }
    }
}