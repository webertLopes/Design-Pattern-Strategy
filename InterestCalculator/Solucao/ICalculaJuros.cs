using InterestCalculator.Solution;

namespace CalculadoraBancaria.Solution
{
    public interface ICalculaJuros
    {
        public decimal ObterTaxaJuros(Pedido pedido);
    }
}
