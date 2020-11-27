using System;
using System.Collections.Generic;

namespace E4
{
    public class RRHH : Empleado
    {
        private int persReferida;

        public RRHH(int cajaBancaria, int persReferida) : base(cajaBancaria)
        {
            this.persReferida = persReferida;
        }

        public override void depositar()
        {
            CajaBancaria1+=5000+(5000*persReferida);
        }
    }
}