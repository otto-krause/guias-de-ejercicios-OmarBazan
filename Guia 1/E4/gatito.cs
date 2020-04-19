namespace E4
{
    public class gatito
    {
        string nombre;
        bool vacunas;
        int energia;

        public gatito(string nombre, bool vacunas, int energia)
        {
            this.nombre=nombre;
            this.vacunas=vacunas;
            this.energia=energia;
        }
        public string nombreDelGatito() //accion nombre
        {
            return nombre;                      
        }
        public bool estaVacunado() //accion vacunado
        {
            return vacunas;
        }
        public void accionJugar(int min) //accion jugar
        {
            energia-=min*2;
        }
        public void comer() //accion comer
        {
            energia+=30;
        }
        public bool estaSaludable() //accion saludable
        {
            return vacunas && energia>30;
        }
    }
}