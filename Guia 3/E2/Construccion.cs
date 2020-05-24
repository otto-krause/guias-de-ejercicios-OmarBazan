using System;
using System.Collections.Generic;

namespace E2
{
    public class Construccion
    {
        int presupuesto;
        int horas;
        List<Contratistas> empleados = new List<Contratistas>();

        public Construccion(int presupuesto, int horas)
        {
            this.presupuesto = presupuesto;
            this.horas = horas;
        }

        public void trabajadores()
        {
            empleados.Add(new Pintores());
            empleados.Add(new Pintores());
            empleados.Add(new Pintores());
            empleados.Add(new Pintores());
            empleados.Add(new Pintores());
            empleados.Add(new Plomeros());
            empleados.Add(new Plomeros());
            empleados.Add(new Plomeros());
            empleados.Add(new Plomeros());
            empleados.Add(new Plomeros());
            empleados.Add(new Albañiles(20, false));
            empleados.Add(new Albañiles(22, true));
            empleados.Add(new Albañiles(35, false));
            empleados.Add(new Albañiles(30, true));
            empleados.Add(new Albañiles(65, true));         
        }
        
        public bool permiso(int presupuesto)
        {
            return presupuesto >= presupuestoTotal(horas);
        }

        public int presupuestoTotal(int hora)
        {
            int precioTotal=0;
            foreach (Contratistas aux in empleados)
            {
                aux.trabajar(hora);
                precioTotal+=aux.cobrar();
            }
            return precioTotal;
        }
    }
}