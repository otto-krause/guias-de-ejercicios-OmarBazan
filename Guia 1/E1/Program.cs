using System;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[10];
            int suma = 0;
            int menor = 0;
            int aux = 0;
            float prom = 0F;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ingrese un numero: ");
                vector[i] = Int32.Parse(Console.ReadLine());     
                suma += vector[i];
                if(vector[i]<menor)
                {
                    menor = vector[i];
                }
            }
            Console.WriteLine("la suma es : "+suma);
            prom = suma/10;
            Console.WriteLine("el promedio es : "+prom);
            Console.WriteLine("el menor es : "+menor);
            for (int i = 0; i < 10; i++)
            {
               for(int j = i+1; j < 10; j++)
		        {
			        if(vector[i]<vector[j])
			        {
				        aux=vector[i];
				        vector[i]=vector[j];
				        vector[j]=aux;
		        	}
		        }
            }
            for(int i=0; i < 10; i++)
	        {
		        Console.WriteLine("mayor a menor"+vector[i]);
	        }
        }
    }
}
