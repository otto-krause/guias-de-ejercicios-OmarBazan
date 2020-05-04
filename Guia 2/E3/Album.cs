using System;
using System.Collections.Generic;

namespace E3
{
    public class Album
    {   
        public List<Figuritas> Estampa = new List<Figuritas>(); 

        public void Agregar(Figuritas Figu)
        {
            int cont=0;
            foreach (Figuritas aux in Estampa)
            {
                if ((Figu.Nombre==aux.Nombre) && (Figu.Posicion==aux.Posicion))
                {
                    cont=1;
                }
                 
            }    
            if(cont==0){
                Estampa.Add(Figu);
            }      
        }

        public int CuantosDelanteros()
        {
            int cont=0;
            foreach (Figuritas aux in Estampa)
            {
               if (aux.Posicion == "delantero" )
               {
                    cont++;                   
               } 
            }
            return cont;
        }

        public int CuantosMediocampistas()
        {
            List<Figuritas> albumAux = new List<Figuritas>();
            foreach (Figuritas aux in Estampa)
            {
               if (aux.Posicion == "mediocampista" )
               {
                    albumAux.Add(aux);                   
               } 
            }
            return albumAux.Count;
        }

        public bool EstaCompleto()
        {
            int aux=0;
            aux=Estampa.Count;
            return (aux==352); 
        }
    }
}