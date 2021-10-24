public struct Pop
{
    public string Name;
    public int Value;
    public string Note;

    public Pop(string name) : this(name, 0, default) { }

    public Pop(string name, string note) : this(name, 0, note) { }

    public Pop(string name, int value, string note)
    {
        Name = name;
        Value = value;
        Note = note;
    }

    public override string ToString()
    {
        if (Value == default) return $"{Name}";
        return $"{Name} {Value}";
    }

    public string ToStringWith(string prefix = default, string postfix = default)
    {
        return $"{prefix}{ToString()}{postfix}";
    }
}