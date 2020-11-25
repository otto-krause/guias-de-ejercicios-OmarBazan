using System;
using System.Collections.Generic;

namespace E3
{
    public class CaballeroDelZodiaco
    {
        string nombre;
        string diosQueApoya;
        private Armadura armadura;
        string signoDelZodiaco;

        public CaballeroDelZodiaco(string nombre, string diosQueApoya, Armadura armadura, string signoDelZodiaco)
        {
            this.nombre = nombre;
            this.diosQueApoya = diosQueApoya;
            this.armadura = armadura;
            this.signoDelZodiaco = signoDelZodiaco;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string DiosQueApoya { get => diosQueApoya; set => diosQueApoya = value; }
        public Armadura Armadura { get => armadura; set => armadura = value; }
        public string SignoDelZodiaco { get => signoDelZodiaco; set => signoDelZodiaco = value; }
    }
}