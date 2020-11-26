using System;
using System.Collections.Generic;
using System.Linq;

namespace E10
{
    public class Compañeros
    {
        string nombre;
        int ganancias;
        int idiomas;
        List<string> viajes;

        public Compañeros(string nombre, int ganancias, int idiomas, List<string> viajes)
        {
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Ganancias { get => ganancias; set => ganancias = value; }
        public int Idiomas { get => idiomas; set => idiomas = value; }
        public List<string> Viajes { get => viajes; set => viajes = value; }
    }
}