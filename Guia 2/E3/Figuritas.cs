using System;
using System.Collections.Generic;

namespace E3
{
    public class Figuritas
    {
        string nombre;
        string posicion;
        string pais;
        int numDeFig;

        public Figuritas(string nombre, string posicion, string pais, int numDeFig)
        {
            this.nombre=nombre;
            this.posicion=posicion;
            this.pais=pais;
            this.numDeFig=numDeFig;
        }

        public string Posicion { get => posicion; set => posicion = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int NumDeFig { get => numDeFig; set => numDeFig = value; }
    }
}