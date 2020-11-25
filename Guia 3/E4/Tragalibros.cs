using System;
using System.Collections.Generic;

namespace E4
{
    public class Tragalibros
    {
        string nombre;
        int edad;
        public List<Libro> Leidos = new List<Libro>();

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }

        public Tragalibros(string nombre, int edad, List<Libro> leidos)
        {
            this.nombre = nombre;
            this.edad = edad;
            Leidos = leidos;
        }

        public void leido(Libro Lib)
        {
            int cont=0;
            foreach(Libro aux in Leidos)
            {
                if(Lib.Titulo == aux.Titulo)
                {
                    cont=1;
                }
            }
            if(cont==0)
            {
                Leidos.Add(Lib);
            }
        }

        public int Ci(List<Libro> Leidos)
        {
            List<Libro> LeidosAux = new List<Libro>();
            foreach(Libro aux in Leidos)
            {
                LeidosAux.Add(aux);
            }
            return(LeidosAux.Count)*5;
        }
    }
}