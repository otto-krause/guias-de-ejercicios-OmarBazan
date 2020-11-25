using System;
using System.Collections.Generic;

namespace E5
{
    public class Supermercado
    {
        List<List<Producto>> Carritos = new List<List<Producto>>();

        public int Ganancias()
        {
            int total=0;
            total=0;
            foreach (Producto aux in Carritos)
            {
                foreach (Producto i in Producto)
                {
                    total+=i.Precio;
                }
                
            }
            return total;
        }
    }
}