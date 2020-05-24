namespace E1
{
    public class Homero : Empleado
    {
        private int donas;

        public Homero(int donas)
        {
            this.donas = donas;
        }

        public bool estaDistraido()
        {
            return donas<2;
        }
        public void compra()
        {
            donas+=12;
        }
        public void come()
        {
            donas--;
        }
    }
}