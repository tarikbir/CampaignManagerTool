using NUnit.Framework;

namespace CampaignManagerUnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            CurrencySystem cs = new CurrencySystem(new List<Currency>()
            {
                new Currency("Faka", 1),
                new Currency("Baka", 8),
                new Currency("Saka", 640)
            });
            treasury = new Treasury(cs);

            int money = 0;
            int.TryParse(txtInput.Text, out money);
            treasury.AddMoney(treasury.CurrencySystem.Currencies[0], money);
        }
    }
}