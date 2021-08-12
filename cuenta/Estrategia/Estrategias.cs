using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using cuenta;


namespace banco.Estrategia
{
    public static class Estrategias 
    {
        static List<IEstrategia> Estra = new List<IEstrategia>()
        {
            new Ahorro(),
            new Cauto(),
            new Emergencia(),

        };
        public static IEstrategia EstrategiaPara(Cliente cliente)
            => (Estra.FirstOrDefault(e => e.EsApto(cliente)));
    }
}