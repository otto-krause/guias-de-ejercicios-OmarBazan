namespace E1
{
    public class Planta
    {
        private int numBarraUranio;
        Mrburns burns;
        private Empleado empleado;

        public Planta(int numBarraUranio, Empleado empleado, Mrburns burns)
        {
            this.numBarraUranio = numBarraUranio;
            this.burns = burns;
            this.empleado = empleado;
        }

        public bool estaEnPeligro()
        {
            return (numBarraUranio>10000 && empleado.estaDistraido()) || !burns.esMillonario();
        }        
        public void cambiarEmpleado(Empleado nuevoEmpleado)
        {
            empleado=nuevoEmpleado;
        }
    }
}