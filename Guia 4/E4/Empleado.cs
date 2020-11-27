using System;
using System.Collections.Generic;

namespace E4
{
    public abstract class Empleado
    {
        private int cajaBancaria;

        protected Empleado(int cajaBancaria)
        {
            this.CajaBancaria1 = cajaBancaria;
        }

        public int CajaBancaria1 { get => cajaBancaria; set => cajaBancaria = value; }

        public void extraer(int sacar)
        {
            CajaBancaria1-=sacar;
        }

        public abstract void depositar();
    }
}