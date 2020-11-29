using System;
using System.Collections.Generic;
using System.Linq;

namespace E5
{
    public class Publico
    {
        private List<Persona> personasAux;
        public List<Persona> Persona_n { get => personasAux; }
 
        public Publico()
        {
            personasAux = new List<Persona>();

            List<string> conocimientos1 = new List<string>{"leer","correr","caminar","natacion","trabajar","comer"};
            List<string> conocimientos2 = new List<string>{"dormishion","jugar","imitacion","manipulacion","estudiar","caminar"};

            Persona p1 = new Persona("pepe",conocimientos1);
            Persona p2 = new Persona("juan",conocimientos2);

            Persona_n.Add(p1);
            Persona_n.Add(p2);
        }  
    }
}