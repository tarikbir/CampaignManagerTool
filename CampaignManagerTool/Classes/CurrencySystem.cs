using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class CurrencySystem : IEnumerable<Currency>
{
    public List<Currency> Currencies { get; private set; }

    public CurrencySystem(List<Currency> currencies)
    {
        Currencies = currencies;
    }

    public static CurrencySystem GetDefaultCurrencySystemForDnd(bool isSimple = false)
    {
        if (isSimple)
        {
            return new CurrencySystem(new List<Currency>() {
                new Currency("Copper Pieces", 1),
                new Currency("Silver Pieces", 10),
                new Currency("Gold Pieces", 100)
            });
        }
        else
        {
            return new CurrencySystem(new List<Currency>() {
                new Currency("Copper Pieces", 1),
                new Currency("Silver Pieces", 10),
                new Currency("Electrum Pieces", 50),
                new Currency("Gold Pieces", 100),
                new Currency("Platinum Pieces", 1000)
            });
        }
    }

    public Currency GetPreviousCurrency(Currency currency)
    {
        return Currencies.Find(c => c.Factor < currency.Factor);
    }

    public Currency GetNextCurrency(Currency currency)
    {
        return Currencies.Find(c => c.Factor > currency.Factor);
    }

    public bool HasCurrency(Currency currency)
    {
        return Currencies.Any(c => c == currency);
    }

    public void AddCurrency(Currency currency)
    {
        //Validation
        Currencies.Add(currency);
    }

    public void RemoveCurrency(Currency currency)
    {
        //Validation
        Currencies.Remove(currency);
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public IEnumerator<Currency> GetEnumerator()
    {
        return Currencies.GetEnumerator();
    }
}