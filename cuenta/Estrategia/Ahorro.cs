using cuenta;
using System;
using System.Collections.Generic;
using System.Text;

namespace banco.Estrategia
{
    public class Ahorro : IEstrategia
    {
        public void Acreditar(Cliente cliente, double monto)
        {
            cliente.AcreditarEfectivo (monto*0.5);
            cliente.Cuenta.Acreditar(monto*0.5);
        }

        public void Debitar(Cliente cliente, double monto)
        {
           if( cliente.Tienealmenos(monto))
           {
               cliente.DebitarEfectivo(monto);
           }
           else
           {
               monto -= cliente.VaciarEfectivo();
               cliente.Cuenta.Debitar(monto);
           }
        }

        public bool EsApto(Cliente cliente) => cliente.Efectivo > 50000;
       
    }
}
