using NUnit.Framework;
using System.Collections.Generic;

namespace CampaignManagerUnitTests
{
    public class Tests
    {
        Treasury treasury;
        [SetUp]
        public void Setup()
        {
            CurrencySystem cs = new CurrencySystem(new List<Currency>()
            {
                new Currency("Ones", 1),
                new Currency("Tens", 10),
                new Currency("Hundreds", 100)
            });
            treasury = new Treasury(cs);
        }

        [Test]
        public void Adds_money_to_empty_treasury()
        {
            treasury.AddMoney(treasury.CurrencySystem.Currencies[0], 8);

            Assert.AreEqual(treasury.Wealth[0].Amount, 8);
        }

        [Test]
        public void Adds_money_to_filled_treasury_with_overflow()
        {
            treasury.AddMoney(treasury.CurrencySystem.Currencies[0], 8);
            treasury.AddMoney(treasury.CurrencySystem.Currencies[1], 8);

            treasury.AddMoney(treasury.CurrencySystem.Currencies[0], 8);

            Assert.AreEqual(treasury.Wealth[0].Amount, 6);
            Assert.AreEqual(treasury.Wealth[1].Amount, 9);
        }

        [Test]
        public void Adds_money_to_big_money_treasury()
        {
            treasury.AddMoney(treasury.CurrencySystem.Currencies[2], 9);
            treasury.AddMoney(treasury.CurrencySystem.Currencies[2], 9);

            Assert.AreEqual(treasury.Wealth[2].Amount, 18);
        }
    }
}