using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.ComponentModel;
using System.Collections.Generic;

namespace Funds.Domain.Tests
{
    [TestClass]
    public class FundsCalculationTests
    {
        private FundsBindingList _funds;

        [TestInitialize()]
        public void Initialize()
        {
            _funds = new FundsBindingList();
            for (int i = 1; i < 10; i++)
            {
                FinancialInstrument bond = FinancialInstrument.Factory.Create<Bond>();
                FinancialInstrument equity = FinancialInstrument.Factory.Create<Equity>();
                bond.Price = equity.Price = i;
                bond.Quantity = equity.Quantity = i;
                _funds.Add(bond);
                _funds.Add(equity);
            }
        }

        [TestMethod]
        public void financial_instruments_should_have_proper_names()
        {
            int bCnt = 0, eCnt = 0;
            foreach (FinancialInstrument fi in _funds)
            {
                if (fi is Bond)
                {
                    Assert.AreEqual("Bond" + (++bCnt).ToString(), fi.Name);
                }
                else if (fi is Equity)
                {
                    Assert.AreEqual("Equity" + (++eCnt).ToString(), fi.Name);
                }
            }
        }

        [TestMethod]
        public void market_value_should_be_calculated()
        {
            foreach (FinancialInstrument fi in _funds)
            {
                Assert.AreEqual(fi.Price* fi.Quantity, fi.MarketValue);
            }
        }

        [TestMethod]
        public void transaction_cost_should_be_calculated_by_type()
        {
            foreach (FinancialInstrument fi in _funds)
            {
                if (fi is Bond)
                {
                    Assert.AreEqual(fi.MarketValue * 0.02m, fi.TransactionCost);
                }else if (fi is Equity)
                {
                    Assert.AreEqual(fi.MarketValue * 0.005m, fi.TransactionCost);
                }
            }
        }

        [TestMethod]
        public void sum_of_funds_stock_weights_should_be_hundred_percent()
        {
            Assert.AreEqual(1m, Math.Round(_funds.Sum(s=>s.StockWeight),2));
        }

        [TestMethod]
        public void summary_of_funds_should_be_calculated()
        {
            FundsBindingList.SummaryItem sBond = _funds.SummaryBindingList.Where(w=>w.Type == "Bond").FirstOrDefault();
            FundsBindingList.SummaryItem sEquity = _funds.SummaryBindingList.Where(w=>w.Type == "Equity").FirstOrDefault();
            FundsBindingList.SummaryItem sAll = _funds.SummaryBindingList.Where(w=>w.Type == "All").FirstOrDefault();

            Assert.AreEqual(3,_funds.SummaryBindingList.Count);
            Assert.IsNotNull(sBond);
            Assert.IsNotNull(sEquity);
            Assert.IsNotNull(sAll);
            Assert.AreEqual(_funds.Where(w => w is Bond).Sum(s => s.Quantity), sBond.Quantity);
            Assert.AreEqual(_funds.Where(w => w is Equity).Sum(s => s.Quantity), sEquity.Quantity);
            Assert.AreEqual(_funds.Sum(s => s.Quantity), sAll.Quantity);
            Assert.AreEqual(_funds.Where(w => w is Bond).Sum(s => s.MarketValue), sBond.MarketValue);
            Assert.AreEqual(_funds.Where(w => w is Equity).Sum(s => s.MarketValue), sEquity.MarketValue);
            Assert.AreEqual(_funds.Sum(s => s.MarketValue), sAll.MarketValue);
            Assert.AreEqual(Math.Round(_funds.Where(w => w is Bond).Sum(s => s.StockWeight),2), Math.Round(sBond.StockWeight,2));
            Assert.AreEqual(Math.Round(_funds.Where(w => w is Equity).Sum(s => s.StockWeight),2), Math.Round(sEquity.StockWeight,2));
            Assert.AreEqual(Math.Round(_funds.Sum(s => s.StockWeight), 2), Math.Round(sAll.StockWeight, 2));
        }
    }
}
