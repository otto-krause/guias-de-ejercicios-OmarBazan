using System;
using System.Collections.Generic;

namespace E4
{
    public class Libro
    {
        string titulo;
        string autor;

        public Libro(string titulo, string autor)
        {
            this.titulo = titulo;
            this.autor = autor;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
    }
}