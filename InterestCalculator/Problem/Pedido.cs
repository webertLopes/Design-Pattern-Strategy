using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator.Problem
{
    public class Pedido
    {
        public decimal Total { get; set; }
        public string? Banco { get; set; }

        public Pedido(decimal total, string banco)
        {
            this.Total = total;
            this.Banco = banco;
        }
        public Decimal ObterPercentualJuros() 
        {
            return 10;
        }       

    }

}
