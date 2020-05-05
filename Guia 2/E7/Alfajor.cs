using System;
using System.Collections.Generic;

namespace E7
{
    public class Alfajor
    {
        string nombre;
        int precio;
        string empresa;

        public Alfajor(string nombre, int precio, string empresa)
        {
            this.nombre = nombre;
            this.precio = precio;
            this.empresa = empresa;
        }

        public int Precio { get => precio; set => precio = value; }
        public string Empresa { get => empresa; set => empresa = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}