using System;
using System.Collections.Generic;

namespace E5
{
    public class Robot : SerPensante
    {
        public Robot(List<string> conocimiento,int puntos) : base(conocimiento,puntos)
        {     
            
        }

        public override void estudiar(string tema)
        {
            Conocimientos.Add(tema);
        }
        
        public override void pensar(string tema)
        {
           Puntos+=Conocimientos.Count;
        }
    }
}