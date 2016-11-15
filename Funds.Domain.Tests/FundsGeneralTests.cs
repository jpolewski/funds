using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.ComponentModel;
using System.Collections.Generic;

namespace Funds.Domain.Tests
{
    [TestClass]
    public class FundsGeneralTests
    {
        private FundsBindingList _funds;

        [TestInitialize()]
        public void Initialize()
        {
            _funds = new FundsBindingList();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void cant_add_financial_instruments_without_price()
        {
            FinancialInstrument fi = FinancialInstrument.Factory.Create<Bond>();
            fi.Quantity = 1;

            _funds.Add(fi);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void cant_add_financial_instruments_without_quantity()
        {
            FinancialInstrument fi = FinancialInstrument.Factory.Create<Bond>();
            fi.Price = 1;

            _funds.Add(fi);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void cant_add_the_same_financial_instruments()
        {
            FinancialInstrument fi = FinancialInstrument.Factory.Create<Bond>();

            _funds.Add(fi);
            _funds.Add(fi);
        }

        [TestMethod]
        public void can_add_correct_financial_instruments()
        {
            FinancialInstrument bond = FinancialInstrument.Factory.Create<Bond>();
            FinancialInstrument equity = FinancialInstrument.Factory.Create<Equity>();
            bond.Price = equity.Price = 1;
            bond.Quantity = equity.Quantity = 1;

            _funds.Add(bond);
            _funds.Add(equity);

            Assert.AreEqual(2, _funds.Count);
        }
    }
}
