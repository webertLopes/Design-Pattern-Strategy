using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator.Solution
{
    public class Pedido
    {
        public decimal Total { get; set; }

        public Pedido(decimal total)
        {
            this.Total = total;
        }
        public Decimal Taxa()
        {
            return 10;
        }

    }
}
