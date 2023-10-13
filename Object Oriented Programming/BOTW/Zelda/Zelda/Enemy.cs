using System;

public class Enemy
{
    public string Name { get; private set; }
    public string Gender { get; private set; }
    public string Race { get; private set; }
    public int Health { get; private set; }
    public int Threat { get; private set; } // out of 10
    public int Damage { get; private set; }
    public virtual string[] EffectiveWeapons { get; }
}