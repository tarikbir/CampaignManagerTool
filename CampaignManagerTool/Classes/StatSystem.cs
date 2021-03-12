using System;

public class StatSystem
{
    private Stat[] Stats;

    public StatSystem(int str, int dex, int con, int intl, int wis, int cha)
    {
        /**Hard-coded stat system for D&D. Will change into custom later.*/
        Stats = new Stat[6]
        {
            new Stat("Strength", "STR", str, CalculateModifier(str)),
            new Stat("Dexterity", "DEX", dex, CalculateModifier(dex)),
            new Stat("Constitution", "CON", con, CalculateModifier(con)),
            new Stat("Intelligence", "INT", intl, CalculateModifier(intl)),
            new Stat("Wisdom", "WIS", wis, CalculateModifier(wis)),
            new Stat("Charisma", "CHA", cha, CalculateModifier(cha))
        };
    }

    public void IncreaseStat(CharacterStat stat, int increase)
    {
        var oldStat = Stats[(int)stat];
        var newValue = Math.Clamp(oldStat.Value + increase, 1, 30);
        Stats[(int)stat] = new Stat(oldStat.FullName, oldStat.Abbreviation, newValue, CalculateModifier(newValue));
    }

    public int CalculateModifier(int value)
    {
        return (int)Math.Floor(((double) Math.Clamp(value, 1, 30) - 10) / 2);
    }

    public Stat GetStat(CharacterStat stat)
    {
        return Stats[(int)stat];
    }

    public override string ToString()
    {
        return string.Join(" | ", Stats);
    }
}

public enum CharacterStat : int
{
    STR = 0,
    DEX = 1,
    CON = 2,
    INT = 3,
    WIS = 4,
    CHA = 5
}