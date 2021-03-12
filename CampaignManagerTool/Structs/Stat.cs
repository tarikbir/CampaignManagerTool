public struct Stat
{
    public string FullName { get; }
    public string Abbreviation { get; }
    public int Value { get; }
    public int Modifier { get; }

    public Stat(string fullName, string abbreviation, int value, int modifier)
    {
        FullName = fullName;
        Abbreviation = abbreviation;
        Value = value;
        Modifier = modifier;
    }

    public override string ToString()
    {
        string modifier = (Modifier >= 0) ? $"+{Modifier}" : $"{Modifier}";
        return $"{Abbreviation} {Value} ({modifier})";
    }
}