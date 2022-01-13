using CalculadoraBancaria.Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator.Solution
{
    public class Santander : ICalculaJuros
    {
        public decimal ObterTaxaJuros(Pedido pedido)
        {
            var total = pedido.Taxa();
            return total * 15 / 100;
        }
    }
}
