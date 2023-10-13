using System;
using Zelda.Properties;

public class Chuchu : Enemy, IFlexible
{
    public enum ChuchuType
    {
        Normal,
        Fire,
        Ice,
        Electric
    }
    
    public enum ChuchuSize
    {
        Small,
        Medium,
        Large
    }
    
    public ChuchuType Type { get; private set; }
    public ChuchuSize Size { get; private set; }

    public Chuchu(ChuchuSize size = ChuchuSize.Medium, ChuchuType type = ChuchuType.Normal)
        : base("Chuchu", "Unknown", "Slime", CalculateHealth(size), CalculateThreat(type), CalculateDamage(type), null)
    {
        Type = type;
        Size = size;
    }
    
    private static int CalculateHealth(ChuchuSize size)
    {
        switch (size)
        {
            case ChuchuSize.Small:
                return 3;
            case ChuchuSize.Medium:
                return 20;
            case ChuchuSize.Large:
                return 48;
            default:
                return 20;
        }
    }
    
    private static int CalculateThreat(ChuchuType type)
    {
        switch (type)
        {
            case ChuchuType.Normal:
                return 6;
            case ChuchuType.Fire:
                return 3;
            case ChuchuType.Ice:
                return 3;
            case ChuchuType.Electric:
                return 4;
            default:
                return 6;
        }
    }
    
    private static int CalculateDamage(ChuchuType type)
    {
        switch (type)
        {
            case ChuchuType.Normal:
                return 5;
            case ChuchuType.Fire:
                return 6;
            case ChuchuType.Ice:
                return 3;
            case ChuchuType.Electric:
                return 9;
            default:
                return 5;
        }
    }

    public override string[] EffectiveWeapons
    {
        get
        {
            switch (Type)
            {
                case ChuchuType.Normal:
                    return new string[] { "Bombs", "Boomerang", "Bow", "Deku Nuts", "Hammer", "Sword" };
                case ChuchuType.Fire:
                    return new string[] { "Ranged", "Ice-Weapons" };
                case ChuchuType.Ice:
                    return new string[] { "Spirit Tracks", "Boomerang", "Bow", "Ranged weapons", "Fire weapons" };
                case ChuchuType.Electric:
                    return new string[] { "Ranged" };
                default:
                    return base.EffectiveWeapons;
            }
        }
    }

    public override void Move(double speed)
    {
        Console.WriteLine($" Chuchu is bouncing around at speed {speed}.");
    }
    
    public void Split()
    {
        Console.WriteLine("Chuchu splits into smaller Chuchus.");
    }

    public void Burst()
    {
        Console.WriteLine("Chuchu bursts when player gets too close.");
    }
}