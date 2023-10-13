using System;
using Zelda.Properties;

public class Keese : Enemy, IFlyable
{
    public enum KeeseType
    {
        Normal,
        Fire,
        Ice,
        Electric
    }

    public KeeseType Type { get; private set; }

    public Keese(KeeseType type = KeeseType.Normal)
        : base("Keese", "Unknown", "Bat", 1, CalculateThreat(type), 3, null)
    {
        Type = type;
    }

    private static int CalculateThreat(KeeseType type)
    {
        switch (type)
        {
            case KeeseType.Normal:
                return 1;
            case KeeseType.Fire:
                return 3;
            case KeeseType.Ice:
                return 4;
            case KeeseType.Electric:
                return 3;
            default:
                return 1;
        }
    }

    public override string[] EffectiveWeapons
    {
        get
        {
            switch (Type)
            {
                case KeeseType.Normal:
                    return new string[] { "Sword", "Whip", "Slingshot", "Bow", "Boomerang" };
                case KeeseType.Fire:
                    return new string[] { "Sword", "Slingshot", "Hero's Bow", "Boomerang", "Whip" };
                case KeeseType.Ice:
                    return new string[] { "Sword", "Shield", "Slingshot", "Boomerang", "Bow" };
                case KeeseType.Electric:
                    return new string[] { "Ranged" };
                default:
                    return base.EffectiveWeapons;
            }
        }
    }

    public override void Attack()
    {
        Console.WriteLine($"Keese attacks with a bite for {Damage} damage!");
    }

    public void Fly()
    {
        Console.WriteLine("Keese is flying.");
    }
    
    public void Screech()
    {
        Console.WriteLine("Keese makes a screeching sound.");
    }

}
