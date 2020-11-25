using System;
using System.Collections.Generic;

namespace E3
{
    public class Armadura
    {
        string nombre;
        string material;

        public Armadura(string nombre, string material)
        {
            this.nombre = nombre;
            this.material = material;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Material { get => material; set => material = value; }
    }
}