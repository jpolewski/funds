using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funds.Domain
{
    public interface ITransactionCostCalc
    {
        Decimal Calculate(FinancialInstrument instrument);
    }
}
