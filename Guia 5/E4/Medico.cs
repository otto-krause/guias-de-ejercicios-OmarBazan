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
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public string Especialidad1 { get => Especialidad; set => Especialidad = value; }
        public int CantidadTurnos1 { get => CantidadTurnos; set => CantidadTurnos = value; }

        public void ocupado()
        {
            CantidadTurnos++;
        }
    }
}