namespace E1
{
    public class Lenny : Empleado
    {
        int cerveza;

        public Lenny()
        {
            this.cerveza = 0;
        }

        public bool estaDistraido()
        {
            return cerveza>3;
        }
        public void toma()
        {
            cerveza++;
        }
    }
}