using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funds.Domain
{
    public class Factory
    {
        public FinancialInstrument Create<T>()
        {
            ITransactionCostCalc typeDependTransactionCost = new TypeDependTransactionCostCalc();
            Type financialType = typeof(T);
            if (financialType == typeof(Bond))
            {
                return new Bond(typeDependTransactionCost);
            }
            else if (financialType == typeof(Equity))
            {
                return new Equity(typeDependTransactionCost);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
