using System;
using System.Collections.Generic;

namespace E4
{
    public class Programador : Empleado
    {
        private string nivel;

        public Programador(int cajaBancaria,string nivel) : base(cajaBancaria)
        {
            this.nivel = nivel;
        }

        public override void depositar()
        {
            if(nivel == "junior")
            {
                CajaBancaria1+=30000;
            }
            else
            if(nivel == "semisenior")
            {
                CajaBancaria1+=40000;
            }
            else   
            if(nivel == "senior")
            {
                CajaBancaria1+=60000;
            }
        }
    }
}