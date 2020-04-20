namespace E5
{
    public class trian
    {
        int l1=0;
        int l2=0;
        int l3=0;

        public trian(int l1, int l2, int l3)
        {
            this.l1=l1;
            this.l2=l2;
            this.l3=l3;
        }

        public bool esEscaleno(int l1, int l2, int l3) //escaleno
        {
            return(l1 != l2 && l1 != l3 && l2 != l3);
        }
        public bool esIsosceles(int l1, int l2, int l3) //isosceles
        {
            return ((l1==l2) && (l1!=l3) || (l1==l3) && (l1!=l2) || (l2==l3) && (l2!=l1) );
        }
        public bool esEquilatero(int l1, int l2, int l3) //equilatero
        {
            return(l1 == l2 && l1 == l3 && l2 == l3);
        }
        public bool esTrianguloRectangulo(int l1, int l2, int l3) //rectangulo
        {
            return((l3*l3)==((l1*l1)+(l2*l2)));
        }
    }
}