using System;
using System.Collections.Generic;

namespace E2
{
    public class Medico
    {
        string Nombre;
        string Apellido;
        string Especialidad;
        int CantidadTurnos;

        public Medico(string Nombre, string Apellido, string Especialidad, int CantidadTurnos)
        {
            this.Nombre=Nombre;
            this.Apellido=Apellido;
            this.Especialidad=Especialidad;
            this.CantidadTurnos=CantidadTurnos;
        }

        public string EstaDisponible() //esta disponible o no
        {
            
            if (CantidadTurnos<50)
            {
                Console.WriteLine("El doctor "+Nombre + Apellido +"esta disponible"); 
            }
            else
            {
                Console.WriteLine("No esta disponible");
            }
        } 
    }
}