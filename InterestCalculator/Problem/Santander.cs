using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator.Problem
{
    public class Santander
    {
        private readonly Pedido pedido;

        public Santander(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public Decimal ObterTaxaJuros() 
        {
            var total = this.pedido.ObterPercentualJuros();
            return total * 20 / 100;
        }

    }
}
