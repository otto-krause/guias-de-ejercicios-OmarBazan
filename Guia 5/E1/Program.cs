using System;
using System.Collections.Generic;
using System.Linq;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {   
            Persona p1 = new Persona("carlos", "fernandez", 19);
            Persona p2 = new Persona("marta", "suarez", 30);
            Persona p3 = new Persona("gonzalo", "perez", 17);
            Persona p4 = new Persona("roberto", "rodriguez", 13);
            Persona p5 = new Persona("pepe", "hernandez", 23);
            Persona p6 = new Persona("juan", "perez", 17);

            List<Persona> personas = new List<Persona>();
            personas.Add(p1);
            personas.Add(p2);
            personas.Add(p3);
            personas.Add(p4);
            personas.Add(p5);
            personas.Add(p6);

            Console.WriteLine("\nPersonas mayores de edad");
            personas.Where(persona => persona.Edad >= 18)
            .ToList()
            .ForEach(persona => Console.WriteLine(persona.Nombre));

            Console.WriteLine("\nPersonas que se llamen juan");
            personas.Where(persona => persona.Nombre == "juan")
            .ToList()
            .ForEach(persona => Console.WriteLine("\n"+persona.Nombre+" "+persona.Apellido ));

            Console.WriteLine("\nPersonas que se apelliden perez");
            personas.Where(persona => persona.Apellido == "perez")
            .ToList()
            .ForEach(persona => Console.WriteLine("\n"+persona.Nombre+" "+persona.Apellido ));
            
        }
    }
}
