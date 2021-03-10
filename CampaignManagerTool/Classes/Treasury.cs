using System.Collections.Generic;
using System.Linq;

public class Treasury
{
    public List<Money> Wealth { get; private set; }
    public CurrencySystem CurrencySystem { get; }

    public Treasury(CurrencySystem currencySystem)
    {
        CurrencySystem = currencySystem;
        Wealth = new List<Money>();
        foreach(var currency in CurrencySystem)
        {
            Wealth.Add(new Money(currency, 0));
        }
    }

    public Treasury(Treasury treasury)
    {
        CurrencySystem = treasury.CurrencySystem;
        Wealth = treasury.Wealth;
    }

    public void AddMoney(Currency currency, int value)
    {
        if (value == 0) return;
        if (!CurrencySystem.HasCurrency(currency)) return;

        var convertedValue = ToInt();
        convertedValue += value * currency.Factor;
        LoadInt(convertedValue);
    }

    public int ToInt()
    {
        return Wealth.Sum(m => m.Amount * m.Currency.Factor);
    }

    public void LoadInt(int value)
    {
        var DescendingCurrencies = CurrencySystem.OrderByDescending(c => c);
        foreach (var item in DescendingCurrencies)
        {
            int setValue = value / item.Factor;
            value -= setValue * item.Factor;
            int index = Wealth.FindIndex(m => m.Currency == item);

            Wealth[index] = new Money(item, setValue);
        }
    }

    public override string ToString()
    {
        return string.Join(" ", Wealth.Select(m => m.Amount + " " + m.Currency));
    }
}
