using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funds.Domain
{
    [DisplayName("Bond")]
    public class Bond : FinancialInstrument
    {
        public Bond(ITransactionCostCalc transactionCostCalc)
            : base(transactionCostCalc)
        {
        }

        [Browsable(false)]
        public override Decimal TransactionCostTolerance
        {
            get
            {
                return 100000m;
            }
        }
    }
}
