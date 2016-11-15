using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Funds.Domain
{
    public class FinancialInstrument : INotifyPropertyChanged
    {
        public static Factory Factory = new Factory();

        protected ITransactionCostCalc transactionCostCalc;


        public FinancialInstrument(ITransactionCostCalc transactionCostCalc)
        {
            this.transactionCostCalc = transactionCostCalc;
        }
        [DisplayName("Type")]
        public String Type
        {
            get
            {
                return this.GetType().Name;
            }
        }
        [DisplayName("Name")]
        public String Name
        {
            get
            {
                return Type + OccurrenceNumber.ToString();
            }
        }
        [DisplayName("Price")]
        public Decimal Price { get; set; }
        [DisplayName("Quantity")]
        public Int32 Quantity { get; set; }

        [DisplayName("Market Value")]
        public virtual Decimal MarketValue
        {
            get
            {
                return Price * Quantity;
            }
        }
        [DisplayName("Transaction Cost")]
        public Decimal TransactionCost
        {
            get
            {
                return transactionCostCalc == null ? 0 : transactionCostCalc.Calculate(this);
            }
        }

        [DisplayName("Stock Weight")]
        public Decimal StockWeight
        {
            get
            {
                return MarketValue / _totalMarketValue;
            }
        }

        [Browsable(false)]
        public Int32 OccurrenceNumber { get;  set; }

        private Decimal _totalMarketValue;
        [Browsable(false)]
        public Decimal TotalMarketValue
        {
            set
            {
                _totalMarketValue = value;
                OnPropertyChanged(this, m => m.StockWeight);
            }
        }
        [Browsable(false)]
        public virtual Decimal TransactionCostTolerance
        {
            get
            {
                return 0;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged<TObject, TProperty>(TObject owner, Expression<Func<TObject, TProperty>> projection)
        {
            if (PropertyChanged != null)
            {
                var memberExpression = (MemberExpression)projection.Body;
                var e = new PropertyChangedEventArgs(memberExpression.Member.Name);
                PropertyChanged(this, e);
            }

        }
    }
}
