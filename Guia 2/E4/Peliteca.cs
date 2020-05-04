using System;
using System.Collections.Generic;

namespace E4
{   
    public class Peliteca
    {
        public List<Peli> cartelera = new List<Peli>();
            public Peliteca()
        {
            Peli p1= new Peli("interestelar","aventura",2014,"nolan");
            Peli p2= new Peli("el origen","ciencia ficcion",2010,"nolan");
            Peli p3= new Peli("toy story 4","animada",2019,"cooley");
            Peli p4= new Peli("actividad paranormal","terror",2007,"peli");
            Peli p5= new Peli("shrek","animada",2001,"adamson");
            Peli p6= new Peli("los vengadores","accion",2012,"whedon");
            Peli p7= new Peli("los vengadores: la era de ultron","accion",2015,"whedon");
            Peli p8= new Peli("los vengadores: infinity war","accion",2018,"russo");
            Peli p9= new Peli("los vengadores: endgame","accion",2019,"russo");
            Peli p10= new Peli("creed","drama",2016,"coogler");

            cartelera.Add(p1);
            cartelera.Add(p2);
            cartelera.Add(p3);
            cartelera.Add(p4);
            cartelera.Add(p5);
            cartelera.Add(p6);
            cartelera.Add(p7);
            cartelera.Add(p8);
            cartelera.Add(p9);
            cartelera.Add(p10);
        }

        public List<Peli> genero(string gen)
        {
            List<Peli> carteAux = new List<Peli>();
            foreach (Peli aux in cartelera)
            {
                if (gen==aux.Genero)
                {
                    carteAux.Add(aux);
                }
            }
            return carteAux;
        }

        public List<Peli> nombre(string nom)
        {
            List<Peli> carteAux = new List<Peli>();
            foreach (Peli aux in cartelera)
            {
                if (nom==aux.Nombre)
                {
                    carteAux.Add(aux);
                }
            }
            return carteAux;
        }

        public List<Peli> año(int año)
        {
            List<Peli> carteAux = new List<Peli>();
            foreach (Peli aux in cartelera)
            {
                if (año==aux.Año)
                {
                    carteAux.Add(aux);
                }
            }
            return carteAux;
        }
        public List<Peli> director(string dire)
        {
            List<Peli> carteAux = new List<Peli>();
            foreach (Peli aux in cartelera)
            {
                if (dire==aux.Director)
                {
                    carteAux.Add(aux);
                }
            }
            return carteAux;
        }

        public  int cantidadTotal()
        {
            return cartelera.Count;
        }

        public int cantidadDeGenero(string gen)
        {
            List<Peli> carteAux = new List<Peli>();
            foreach (Peli aux in cartelera)
            {
                if (gen==aux.Genero)
                {
                    carteAux.Add(aux);
                }
            }
            return carteAux.Count;
        }
    }
}