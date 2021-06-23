
using banco.Estrategia;
using System;
using System.Collections.Generic;
using System.Text;

namespace cuenta
{
    public class Cliente
    {
        public IEstrategia estrategia;
        public cuenta Cuenta { get; set; }
        public string Nombre;
        public string Apellido;
        public double Efectivo { get; private set; }
        public double saldo { get; set; }

        public Cliente()
        {
            Cuenta = new cuenta();
            Efectivo = 0;
        }
        public int Cbu => Cuenta.Cbu ;

        public void Acreditar(double monto)
        {
            Efectivo = Efectivo + monto;
            Cuenta.Acreditar(monto * 0.2);
        }
        public void Debitar(double monto)
        {
            Efectivo = Efectivo - monto;
            Cuenta.Debitar(monto / 0.2);

        }
        public bool Tienealmenos(double monto) => saldo >= monto;
             
        }
    }


    

