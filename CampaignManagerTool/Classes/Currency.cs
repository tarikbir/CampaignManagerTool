using System;

public class Currency : IComparable
{
    public string Name { get; set; }
    public int Factor { get; }

    public Currency(string name, int factor)
    {
        if (factor <= 0) throw new Exception("Factor cannot be zero.");
        Name = name;
        Factor = factor;
    }

    public Currency(string name)
    {
        /**Set the base Currency.**/
        Name = name;
        Factor = 1;
    }

    public override string ToString()
    {
        return Name;
    }

    public int CompareTo(object obj)
    {
        //if (obj.GetType() != typeof(Currency)) return int.MinValue; throw new Exception();
        return (obj as Currency).Factor < Factor ? 1 : (obj as Currency).Factor == Factor ? 0 : -1;
    }
}