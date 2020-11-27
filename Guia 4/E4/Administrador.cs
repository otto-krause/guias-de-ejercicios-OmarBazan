using System;
using System.Collections.Generic;

namespace E4
{
    public class Administrador : Empleado
    {
        public Administrador(int cajaBancaria) : base(cajaBancaria)
        {
        }

        public override void depositar()
        {
            CajaBancaria1+=35000;
        }
    }
}