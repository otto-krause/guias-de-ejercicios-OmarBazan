namespace E6
{
    public class operadores
    {
        int num=0;
        int num2=0;

        public operadores(int num, int num2)
        {
            this.num=num;
            this.num2=num2;
        }

        public int fibonacci(int num) //fibonacci (arreglar)
        {
            int fibo=0;
            int fibo1=1;
            int fibo2=0;

            while(fibo1<=num)
            {
                fibo2=fibo1+fibo;
                fibo=fibo1;
                fibo1=fibo2; 
            }
            return fibo1;
        }
       public int factorial(int num) //factorial (arreglar)
        {
            int aux=0;
            for (int i = 0; i < num; i++)
            {
                aux=num*i;
            }
            return aux;
        }
        public int mayor(int num, int num2) //numero mayor
        {
            int alto=0;
            alto=num>num2 ? num : num2;
            return alto;
        }
        public int menor(int num, int num2) //numero menor
        {
            int bajo=0;
            bajo=num<num2 ? num : num2;
            return bajo;
        }
        public int cubo(int num) //el cubo de un numero
        {
            return(num*num*num);
        }
    }
}