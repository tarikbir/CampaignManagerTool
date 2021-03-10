using System.Collections.Generic;
using System.Linq;

namespace CampaignManagerTool.Unused
{
    internal class WealthItem
    {
        internal Dictionary<Currency, int> TotalWealth;

        internal void Initialize()
        {
            TotalWealth = new Dictionary<Currency, int>() { { new Currency("Base Currency", 1), 0 } };
        }

        internal void AddMoney(Currency currency, int value)
        {
            if (value == 0) return;
            if (!TotalWealth.ContainsKey(currency)) return;
            TotalWealth[currency] += value;
        }

        internal void AddCurrency(Currency currency)
        {
            //Validation
            TotalWealth.Add(currency, 0);
        }

        internal void RemoveCurrency(Currency currency)
        {
            //Validation
            TotalWealth.Remove(currency);
        }

        internal List<Currency> GetCurrencies()
        {
            return TotalWealth.Keys.ToList();
        }

        internal void ConvertMoney(Currency currency)
        {
            /**Will Do Later, this converts currencies into others and adds the remainder to wealth.**/
            //var factor = currency.Factor / Currency.Factor;
            //return factor.Value;
        }

        public override string ToString()
        {
            string totalWealth = "";
            foreach (var item in TotalWealth)
            {
                totalWealth += item.Value + " " + item.Key.Name + " ";
            }
            return $"{totalWealth}";
        }
    }
}
