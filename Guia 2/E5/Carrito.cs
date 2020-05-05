using System;
using System.Collections.Generic;

namespace E5
{
    public class Carrito
    {
        List<Producto> changuito1 = new List<Producto>(); 
        List<Producto> changuito2 = new List<Producto>();
        List<Producto> changuito3 = new List<Producto>();
        List<List<Producto>> Carritos = new List<List<Producto>>();
        public Carrito()
        {
            Producto p1= new Producto("detergente ",35); 
            Producto p2= new Producto("papas fritas ",50);
            Producto p3= new Producto("arroz ",32);
            Producto p4= new Producto("fideos ",40);
            Producto p5= new Producto("coca cola ",95);
            Producto p6= new Producto("harina ",55);
            Producto p7= new Producto("galletas ",27);
            Producto p8= new Producto("jabon ",20);
            Producto p9= new Producto("leche ",37);
            Producto p10= new Producto("lentejas ",30);
            Producto p11= new Producto("helados ",120);
            Producto p12= new Producto("huevo ",40);

            changuito1.Add(p1);
            changuito1.Add(p3);
            changuito1.Add(p5);
            changuito1.Add(p11);

            changuito2.Add(p12);
            changuito2.Add(p10);
            changuito2.Add(p10);
            changuito2.Add(p7);
            changuito2.Add(p2);
        
            changuito3.Add(p4);
            changuito3.Add(p6);
            changuito3.Add(p8);
            changuito3.Add(p9);
            changuito3.Add(p11);
            changuito3.Add(p6);    

            Carritos.Add(changuito1); 
            Carritos.Add(changuito2);
            Carritos.Add(changuito3);  
        }
    }
}