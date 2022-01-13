using InterestCalculator.Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraBancaria.Solution
{
    public class Itau : ICalculaJuros
    {
        public decimal ObterTaxaJuros(Pedido pedido)
        {
            var total = pedido.Taxa();
            return total * 30 / 100;
        }
    }
}
