public struct Money
{
    public Currency Currency;
    public int Amount;

    public Money(Currency currency, int amount)
    {
        Currency = currency;
        Amount = amount;
    }

    public static Money operator +(Money moneyA, Money moneyB)
    {
        if (moneyA.Currency != moneyB.Currency) return moneyA;
        return new Money(moneyA.Currency, moneyA.Amount + moneyB.Amount);
    }

    public static Money operator -(Money moneyA, Money moneyB)
    {
        return moneyA + new Money(moneyB.Currency, -moneyB.Amount);
    }
}
