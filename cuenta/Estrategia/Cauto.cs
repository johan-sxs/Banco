using cuenta;
using System;

namespace banco.Estrategia
{
    public class Cauto : IEstrategia
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
