
using System.Linq;
using banco.Estrategia;
using System;
using System.Collections.Generic;
using System.Text;

namespace cuenta
{
    public class Cliente
    {
        public IEstrategia Estrategia;
        public cuenta Cuenta { get; set; }
        public string Nombre;
        public string Apellido;
        public double Efectivo { get; private set; }


        public Cliente()
        {
            Cuenta = new cuenta();

        }
        public double Saldo => Efectivo + Cuenta.Saldo;
        public int Cbu => Cuenta.Cbu;

        public void Acreditar(double monto)
        {
            Estrategia.Acreditar(this, monto);
            if (!Estrategia.EsApto(this))
            {
                Estrategias.EstrategiaPara(this);
            }
        }
        public void Debitar(double monto)
        {
            Estrategia.Debitar(this, monto);
            if (!Estrategia.EsApto(this))
            {
                Estrategias.EstrategiaPara(this);
            }

        }
        public bool Tienealmenos(double monto) => Saldo >= monto;
        public void DebitarEfectivo(double monto) => Efectivo -= monto;
        public void AcreditarEfectivo(double monto) => Efectivo += monto;
        internal double VaciarEfectivo()
        {
            var Efectivo = this.Efectivo;
            Efectivo = 0;
            return Efectivo;
        }
    }
}




