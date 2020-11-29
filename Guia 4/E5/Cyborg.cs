using System;
using System.Collections.Generic;

namespace E5
{
    public class Cyborg : SerPensante
    {
        List<string> Intereses = new List<string>();
        public Cyborg(List<string> conocimiento,List<string> intereses,int puntos) : base(conocimiento,puntos)
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
            Puntos+=Conocimientos.Count;
        }
    }
}