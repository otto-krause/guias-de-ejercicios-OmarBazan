using System;
using System.Collections.Generic;
using System.Linq;

namespace E2
{
    public class Clinica
    {
        public List<Medico> ListDr = new List<Medico>();
        public Clinica()
        {
            Medico medic1 = new Medico("Juan","Martinez","cirujano",35);
            Medico medic2 = new Medico("Antonio","Gonzalez","dentista",5);
            Medico medic3 = new Medico("Maria","Ramirez","oftamologo",73);
            Medico medic4 = new Medico("Ricardo","Fernandez","cirujano",69);
            Medico medic5 = new Medico("Flor","Gimenez","traumatologia",51);

            ListDr.Add(medic1);
            ListDr.Add(medic2);
            ListDr.Add(medic3);
            ListDr.Add(medic4);
            ListDr.Add(medic5);
        }

        public Medico estaDisponible(string especialidad)
        {
            List<Medico> listaFiltrada=ListDr.Where(Medico => Medico.CantidadTurnos1 <50 && Medico.Especialidad1 == especialidad )
            .ToList();
            foreach(Medico aux in listaFiltrada)
            {  
                    aux.ocupado();
                    return aux;
            }
            return null;
        }
    }
}