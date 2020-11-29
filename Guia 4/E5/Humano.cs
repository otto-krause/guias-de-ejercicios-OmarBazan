using System;
using System.Collections.Generic;

namespace E5
{
    public class Humano : SerPensante
    {
        List<string> Intereses = new List<string>();
        public Humano(List<string> conocimiento,List<string> intereses,int puntos) : base(conocimiento,puntos)
        {
            Intereses=intereses;
        }

        public override void estudiar(string tema)
        {
            Conocimientos.Add(tema);
            if(Intereses.Contains(tema))
                Puntos++;
        }

        public override void pensar(string tema)
        {
            Conocimientos.Reverse();
            int i=0;
            while(i<5 && Conocimientos.Count>i)
            {
                if (Conocimientos[i] == tema)
                {
                    Puntos+=5;
                }
                i++;
            }
        }
    }
}