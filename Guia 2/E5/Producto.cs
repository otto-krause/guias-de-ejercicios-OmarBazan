using System;
using System.Collections.Generic;

namespace E5
{
    public class Producto
    {
        string nombre;
        int precio;

        public Producto(string nombre, int precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio { get => precio; set => precio = value; }
    }
}