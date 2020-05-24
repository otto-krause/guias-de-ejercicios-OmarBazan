namespace E1
{
    public class Mrburns
    {
        bool tieneRiquezas;

        public Mrburns()
        {
            this.tieneRiquezas = true;
        }

        public bool esMillonario()
        {
            return tieneRiquezas;
        }
        public void despojarRiquezas()
        {
            tieneRiquezas = false; 
        }
    }
}