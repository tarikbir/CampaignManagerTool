using System.Collections.Generic;
using System.Windows.Controls;

public abstract class Creature
{
    public string Name;
    public CreatureSize Size;
    public string Alignment;

    public string ArmorClass;
    public string HitPoints;
    public List<Pop> Speed;

    public StatSystem Stats;

    public Image Image;
}