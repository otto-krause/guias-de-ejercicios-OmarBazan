using System;
using System.Collections.Generic;

namespace E6
{
    public class Steam
    {   
        List<Calificacion> granTurismo = new List<Calificacion>();
        List<Calificacion> amnesia = new List<Calificacion>();
        List<Calificacion> narutoShippuden = new List<Calificacion>();
        List<Juego> ListaDeJuegos = new List<Juego>();
        
        public Steam()
        {   
            Calificacion gt1 = new Calificacion(1, "Buenas escenas de paisaje");    
            Calificacion gt2 = new Calificacion(1, "Me gustan los nuevos autos que metieron");
            Calificacion gt3 = new Calificacion(1, "Repetitivo");

            granTurismo.Add(gt1);
            granTurismo.Add(gt2);
            granTurismo.Add(gt3);

            Calificacion amnesia1 = new Calificacion(3, "Muy bueno, me asuste mucho, me gusto el final");
            Calificacion amnesia2 = new Calificacion(3, "Trae el mismo ambiente que la primera entrega, me encanto");

            amnesia.Add(amnesia1);
            amnesia.Add(amnesia2);

            Calificacion narutoShippudenStorm1= new Calificacion(4, "Muy buena historia y buenas peleas");
            Calificacion narutoShippudenStorm2 = new Calificacion(5, "Me gusta pero tiene demasiados dlcs");
            Calificacion narutoShippudenStorm3 = new Calificacion(3, "Espero la proxima entrega");
    
            narutoShippuden.Add(narutoShippudenStorm1);
            narutoShippuden.Add(narutoShippudenStorm2);
            narutoShippuden.Add(narutoShippudenStorm3);

            Juego game=new Juego("Gran turismo", "carrera",granTurismo);
            ListaDeJuegos.Add(game);

            Juego game1=new Juego("Amenesia", "terror", amnesia);
            ListaDeJuegos.Add(game1);

            Juego game2=new Juego("Naruto Shippuden", "pelea", narutoShippuden); 
            ListaDeJuegos.Add(game2);
        }
        
        public List<Juego> porGenero(string gen)
        {
            List<Juego> genero = new List<Juego>();
            foreach (Juego aux in ListaDeJuegos)
            {
                if(gen==aux.Genero)
                {
                    genero.Add(aux);
                }
            }
            return genero;
        }
    
        private float promedio(Juego game1)
        {   
            int total=0;
            foreach (Calificacion aux in game1.Punto)
            {
                total+=aux.Nota;
            }
            return total/game1.Punto.Count;   
        }

        public List<Juego> porCalificacion(string calif)
        {
            List<Juego> Calificacion = new List<Juego>();
            foreach (Juego aux in ListaDeJuegos)
            {
                switch (calif)
                {
                    case "alta":
                        if (promedio(aux)>=4)
                        {
                            Calificacion.Add(aux);   
                        }
                        break;
                    case "media":
                        if (promedio(aux)==3)
                        {
                            Calificacion.Add(aux);   
                        }
                        break;
                    case "baja":
                        if (promedio(aux)<=2)
                        {
                            Calificacion.Add(aux);   
                        }
                        break;
                }    
            }
            return Calificacion;
        }

        
    }
}