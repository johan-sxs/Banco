
using System.Linq;
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

        public  void Acreditar(double monto)
        {
            estrategia.Acreditar(Efectivo=Efectivo);
        }
        public void Debitar(double monto)
        {
            estrategia.Debitar(this.monto);
            if (!estrategia.EsApto(this))
            estrategia.Asignar(this);

        }
        public bool Tienealmenos(double monto) => saldo >= monto;
             
        }
    }


    

