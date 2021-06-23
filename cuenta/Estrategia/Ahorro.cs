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
            throw new NotImplementedException();
        }

        public void Debitar(Cliente cliente, double monto)
        {
            throw new NotImplementedException();
        }

        public bool EsApto(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
