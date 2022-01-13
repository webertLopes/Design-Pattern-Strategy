using CalculadoraBancaria.Solution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator.Solution
{
    public class CalculadoraJuros
    {
        private readonly ICalculaJuros _calculaJuros;

        public CalculadoraJuros(ICalculaJuros calculaJuros)
        {
            this._calculaJuros = calculaJuros;
        }

        public decimal CalculaJuros(Pedido pedido) 
        {
            return _calculaJuros.ObterTaxaJuros(pedido);
        }

    }
}
