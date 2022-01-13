using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator.Problem
{
    public class CalculadoraJuros
    {
        public Decimal? CalculadoraJurosPedido(Pedido pedido) 
        {
            if (pedido.Banco == "Santander")
            {
                var banco = new Santander(pedido);
                return banco.ObterTaxaJuros();                
            }

            if (pedido.Banco == "Bradesco")
            {
                var banco = new Bradesco(pedido);
                return banco.ObterTaxaJuros();
            }

            if (pedido.Banco == "Itau")
            {
                var banco = new Itau(pedido);
                return banco.ObterTaxaJuros();
            }

            return null;
        }
    }
}
