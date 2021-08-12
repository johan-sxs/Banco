using System;
using System.Collections.Generic;
using System.Text;

namespace cuenta
{
    public class cuenta
    {
        public int Cbu { get; set; }
        public double Saldo;

        private static int Contador { get; set; } = 0;
        public cuenta()

        {
            Contador++;
            Cbu = Contador;
            Saldo = 0;

        }
        public double Acreditar(double monto) => Saldo += monto;


        public double Debitar(double monto) => Saldo -= monto;


        public bool Tienealmenos(double monto) => Saldo >= monto;
        internal double VaciarCuenta()
        {
            var Saldo = this.Saldo;
            Saldo = 0;
            return Saldo;
        }
    }
}
