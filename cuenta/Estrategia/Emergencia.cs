using cuenta;
using System;

namespace banco.Estrategia
{
    public class Emergencia : IEstrategia
    {
        public void Acreditar(Cliente cliente, double monto)
        {
            cliente.AcreditarEfectivo(monto);
        }

        public void Debitar(Cliente cliente, double monto)
        {
           if(cliente.Cuenta.Tienealmenos(monto))
           {
               cliente.Cuenta.Debitar(monto);
           }
         else
         {
           monto-= cliente.Cuenta.VaciarCuenta();
           cliente.DebitarEfectivo(monto);
         }

        }
        public bool EsApto(Cliente cliente) => cliente.Efectivo<10000;
    }
}
