using System;
using System.Collections.Generic;

namespace E6
{
    public class Calificacion
    {
        int nota;
        string comentario;

        public Calificacion(int nota, string comentario)
        {
            this.nota = nota;
            this.comentario = comentario;
        }

        public int Nota { get => nota; set => nota = value; }
        public string Comentario { get => comentario; set => comentario = value; }
    }
}