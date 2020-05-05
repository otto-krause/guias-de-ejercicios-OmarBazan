using System;
using System.Collections.Generic;

namespace E6
{
    public class Juego
    {
            string titulo;
            string genero;
            List<Calificacion> punto= new List<Calificacion>();

        public Juego(string titulo, string genero, List<Calificacion> punto)
        {
            this.titulo = titulo;
            this.genero = genero;
            this.punto = punto;
        }

        public string Genero { get => genero; set => genero = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public List<Calificacion> Punto { get => punto; set => punto = value; }
    }   
}