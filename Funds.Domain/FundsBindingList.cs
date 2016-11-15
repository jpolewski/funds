using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funds.Domain
{
    public class FundsBindingList : BindingList<FinancialInstrument>
    {
        public class SummaryItem
        {
            [DisplayName("Type")]
            public String Type { get; set; }
            [DisplayName("Total Number")]
            public Int32 Quantity { get; set; }
            [DisplayName("Total Market Value")]
            public Decimal MarketValue { get; set; }
            [DisplayName("Total Stock Weight")]
            public Decimal StockWeight { get; set; }
        }

        private Dictionary<Type, Int32> _fundsTypeOccurrrences = new Dictionary<Type, int>();
        private Decimal _totalMarketValue = 0;

        private BindingList<SummaryItem> _summaryBindingList = 
            new BindingList<SummaryItem>() { 
                                                new SummaryItem() { Type = "Equity" }, 
                                                new SummaryItem() { Type = "Bond" },
                                                new SummaryItem() { Type = "All" }
                                            };

        public BindingList<SummaryItem> SummaryBindingList {
            get
            {
                return _summaryBindingList;
            }
        }

        protected override void InsertItem(int index, FinancialInstrument item)
        {
            ValidateItem(item);
            UpdateTypeOccurrences(item);
            base.InsertItem(index, item);
            UpdateTotalMarketValue(item);
            UpdateSummary(item);
        }

        private void ValidateItem(FinancialInstrument item)
        {
            if (item.Price <= 0 || item.Quantity <= 0)
            {
                throw new ArgumentException("Price and Quantity are required");
            }
            if (this.Items.Contains(item))
            {
                throw new ArgumentException("Item already exists in the list");
            }
        }

        private void UpdateTypeOccurrences(FinancialInstrument item)
        {
            Type t = item.GetType();
            if (!_fundsTypeOccurrrences.ContainsKey(t))
            {
                _fundsTypeOccurrrences.Add(t, 0);
            }
            _fundsTypeOccurrrences[t] = ++_fundsTypeOccurrrences[t];
            item.OccurrenceNumber = _fundsTypeOccurrrences[t];
        }
        
        private void UpdateTotalMarketValue(FinancialInstrument item)
        {
            _totalMarketValue += item.MarketValue;
            foreach (FinancialInstrument fi in this.Items)
            {
                fi.TotalMarketValue = _totalMarketValue;
            }
        }
        private void UpdateSummary(FinancialInstrument item)
        {
            Type t = item.GetType();
            SummaryItem siType = _summaryBindingList.Where(w => w.Type == t.Name).FirstOrDefault();
            SummaryItem siAll = _summaryBindingList.Where(w => w.Type == "All").FirstOrDefault();
            if (siType != null)
            {
                siType.Quantity += item.Quantity;
                siType.MarketValue += item.MarketValue;
                siAll.Quantity += item.Quantity;
                siAll.MarketValue += item.MarketValue;
            }
            foreach (SummaryItem si in _summaryBindingList)
            {
                si.StockWeight = si.MarketValue == 0 ? 0 : si.MarketValue / siAll.MarketValue;
            }
            _summaryBindingList.ResetBindings();
        }

        
    }
}
