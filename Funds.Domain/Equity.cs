using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funds.Domain
{
    [DisplayName("Equity")]
    public class Equity : FinancialInstrument
    {
        public Equity(ITransactionCostCalc transactionCostCalc)
            : base(transactionCostCalc)
        {
        }

        [Browsable(false)]
        public override Decimal TransactionCostTolerance
        {
            get
            {
                return 200000m;
            }
        }
    }
}
