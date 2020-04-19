namespace E5
{
    public class trian
    {
        int l1=1;
        int l2=1;
        int l3=1;

        public trian(int l1, int l2, int l3)
        {
            this.l1=l1;
            this.l2=l2;
            this.l3=l3;
        }

        public bool esEscaleno(int l1, int l2, int l3) //escaleno
        {
            if (l1 != l2 && l1 != l3 && l2 != l3)
                return true;
                else
                {
                    return false;
                }
        }
        public bool esIsosceles(int l1, int l2, int l3) //isosceles
        {
            if (l1==l2 || l1==l3 || l2==l3)
                return true;
                else
                {
                    return false;
                }
        }
        public bool esEquilatero(int l1, int l2, int l3) //equilatero
        {
            if (l1 == l2 && l1 == l3)
                return true;
                else
                {
                    return false;
                }
        }
       /* public bool esTrianguloRectangulo(int l1, int l2, int l3) //rectangulo
        {
            if ()
            {
                return true;
            }
        }*/
    }
}