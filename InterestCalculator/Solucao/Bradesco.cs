using CalculadoraBancaria.Solution;

namespace InterestCalculator.Solution
{
    public class Bradesco : ICalculaJuros
    {
        public decimal ObterTaxaJuros(Pedido pedido)
        {
            var total = pedido.Taxa();
            return total * 25 / 100;
        }
    }
}
