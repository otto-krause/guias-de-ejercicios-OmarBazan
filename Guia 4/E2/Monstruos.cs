using System;
using System.Collections.Generic;

namespace E2
{
    public abstract class Monstruos
    {
        int respeto;
        string nombre;

        public Monstruos(int respeto, string nombre)
        {
            this.respeto = respeto;
            this.nombre = nombre;
        }

        public int Respeto { get => respeto; set => respeto = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public abstract void asustar();

        public abstract void reir();

    }
}