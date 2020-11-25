using System;
using System.Collections.Generic;
using System.Linq;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            Armadura a1 = new Armadura("pecheraB", "bronce");
            Armadura a2 = new Armadura("pecheraO", "oro");
            
            CaballeroDelZodiaco cz1 = new CaballeroDelZodiaco("pepe", "atena", a1, "capricornio");
            CaballeroDelZodiaco cz2 = new CaballeroDelZodiaco("juan", "zeus", a2, "cancer");
            CaballeroDelZodiaco cz3 = new CaballeroDelZodiaco("marcelo", "hades", a2, "acuario");
            CaballeroDelZodiaco cz4 = new CaballeroDelZodiaco("guren", "hades", a2, "sagitario");

            List<CaballeroDelZodiaco> caballeroDelZodiacos = new List<CaballeroDelZodiaco>();

            caballeroDelZodiacos.Add(cz1);
            caballeroDelZodiacos.Add(cz2);
            caballeroDelZodiacos.Add(cz3);
            caballeroDelZodiacos.Add(cz4);

            Console.WriteLine("\nArmadura de los caballeros que apoyan atena");
            caballeroDelZodiacos.Where(apoya => apoya.DiosQueApoya == "atena")
            .ToList()
            .ForEach(caballeroDelZodiacos => Console.WriteLine(caballeroDelZodiacos.Nombre+" "+caballeroDelZodiacos.Armadura.Nombre+" "+ caballeroDelZodiacos.Armadura.Material));

            Console.WriteLine("\nMostrar los nombres de los dioses sin repetir");
            List<string> dios= new List<string>();
            caballeroDelZodiacos.ForEach(d => dios.Add(d.DiosQueApoya));
            var noRepetidos = dios.Distinct();
            foreach(var d in noRepetidos)Console.WriteLine(d);

            Console.WriteLine("\nMostrar a todos los signos del zodiaco que empiecen con la letra c");
            caballeroDelZodiacos.Where(zodiaco => zodiaco.SignoDelZodiaco.StartsWith("c"))
            .ToList()
            .ForEach(caballeroDelZodiacos => Console.WriteLine(caballeroDelZodiacos.Nombre+" "+caballeroDelZodiacos.SignoDelZodiaco));
        }
    }
}
