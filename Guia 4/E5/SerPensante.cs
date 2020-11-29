using System;
using System.Collections.Generic;

namespace E5
{
    public abstract class SerPensante
    {
        protected List<string> Conocimientos;
        protected List<string> intereses;
        protected int Puntos=0;

        public SerPensante(List<string> conocimientos, int puntos)
        {
            Conocimientos = conocimientos;
            Puntos = puntos;
        }

        public int puntos { get => Puntos;}

        public abstract void estudiar(string tema);
        
        public abstract void pensar(string tema);
    }
}