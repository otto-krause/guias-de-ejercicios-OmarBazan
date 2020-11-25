using System;
using System.Collections.Generic;
using System.Linq;

namespace E6
{
    public class Peliteca
    {
        List<Pelicula> cartelera = new List<Pelicula>();

        public Peliteca()
        {
            Pelicula p1= new Pelicula("interestelar","aventura",2014,"nolan");
            Pelicula p2= new Pelicula("el origen","ciencia ficcion",2010,"nolan");
            Pelicula p3= new Pelicula("toy story 4","animada",2019,"cooley");
            Pelicula p4= new Pelicula("actividad paranormal","terror",2007,"peli");
            Pelicula p5= new Pelicula("shrek","animada",2001,"adamson");
            Pelicula p6= new Pelicula("los vengadores","accion",2012,"whedon");
            Pelicula p7= new Pelicula("los vengadores: la era de ultron","accion",2015,"whedon");
            Pelicula p8= new Pelicula("los vengadores: infinity war","accion",2018,"russo");
            Pelicula p9= new Pelicula("los vengadores: endgame","accion",2019,"russo");
            Pelicula p10= new Pelicula("creed","drama",2016,"coogler");

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

        public List<Pelicula> buscarGenero(string gen)
        {
            List<Pelicula> genero = cartelera.Where(g => g.Genero == gen)
            .ToList();
            return genero;
        }

        public List<Pelicula> buscarNombre(string nom)
        {
            List<Pelicula> nombre = cartelera.Where(n => n.Nombre == nom)
            .ToList();
            return nombre;
        }

        public List<Pelicula> buscarAño(int anio)
        {
            List<Pelicula> año = cartelera.Where(a => a.Año == anio)
            .ToList();
            return año;
        }

        public List<Pelicula> buscarDirector(string direc)
        {
            List<Pelicula> director = cartelera.Where(d => d.Director == direc)
            .ToList();
            return director;         
        }

        public int cantidadPeliculas()
        {
            return cartelera.Count;
        }
        public int cantidadGenero(string genero)
        {
            List<Pelicula> cantidadgenero = cartelera.Where(cg => cg.Genero == genero)
            .ToList();
            return cantidadgenero.Count;
        }
    }
}