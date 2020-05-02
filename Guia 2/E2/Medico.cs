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

        public string Nombre1 { get => Nombre; set => Nombre = value; }

        public bool libre()
        {
            return CantidadTurnos < 50;
        }

        public bool turno(string espec)
        {
            return this.Especialidad==espec && libre();
        }

        public void ocupado()
        {
            CantidadTurnos++;
        }
    }
}