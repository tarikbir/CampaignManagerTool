using System.Collections.Generic;

public class NPC : Creature
{
    public string Type;

    public List<Stat> SavingThrows;
    public string Skills;

    public string DamageResistances;
    public string DamageImmunities;
    public string ConditionImmunities;
    public List<Pop> Senses;
    public List<Pop> Languages;
    public int ChallengeRating;
    public string Environment;

    public List<string> Traits;

    public List<string> Actions;

    public List<string> Reactions;

    public List<List<string>> Other;
}
