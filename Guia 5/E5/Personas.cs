using System;
using System.Collections.Generic;
using System.Linq;

namespace E5
{
    public class Persona
    {
        private List<string> Conocimientos_p;
        public List<string> Conocimietos;
        public string Nombre;

        public Persona(string nombre, List<string> Conocimietos)
        {
            Nombre=nombre;
            Conocimientos_p = Conocimietos;
        }

        public List<string> Conocimientos { get => Conocimientos_p; set => Conocimientos_p = value; }

        public List<string> obtenerLosUltimos5()
        {
            Conocimientos_p.Reverse();
            List<string> lista = new List<string>();
            for (int i = 0 ; i < 5 ; i++)
            {
                lista.Add(Conocimientos_p[i]);
            }
            return lista;
        }

        public List<string> obtenerLosPrimeros4()
        {
            List<string> lista = new List<string>();
            for(int i = 0; i < 4 ; i++)
            {
                lista.Add(Conocimientos_p[i]);
            }     
            lista.Sort();
            return lista;   
        }

        public List<string> terminaCION()
        {
            var lista = Conocimientos_p.Where(x => x.EndsWith("cion")).ToList();
            return lista.ToList();
        } 
    }
}