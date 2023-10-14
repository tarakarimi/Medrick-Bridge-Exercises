using System;
using Zelda.Properties;

public class Bokoblin : Enemy, IEatable, ISleepable, ISneakable
{
    public enum BokoblinType
    {
        Red,
        Blue,
        Black,
        Stalkoblin,
        Cursed,
        Silver,
        Golden
    }

    public BokoblinType Type { get; private set; }
    public BokoblinType UpgradeFrom { get; private set; }
    public BokoblinType UpgradeTo { get; private set; }

    public Bokoblin(BokoblinType type = BokoblinType.Red)
        : base("Bokoblin", "Unknown", "Bokoblin", CalculateHealth(type), 8, 5, GetEffectiveWeapons())
    {
        Type = type;
        SetUpgradeInfo();
    }

    private static int CalculateHealth(BokoblinType type)
    {
        switch (type)
        {
            case BokoblinType.Red:
                return 30;
            case BokoblinType.Blue:
                return 72;
            case BokoblinType.Black:
                return 240;
            case BokoblinType.Stalkoblin:
                return 1;
            case BokoblinType.Silver:
                return 720;
            case BokoblinType.Golden:
                return 1080;
            default:
                return 30;
        }
    }
    
    private void SetUpgradeInfo()
    {
        switch (Type)
        {
            case BokoblinType.Red:
                UpgradeFrom = BokoblinType.Red;
                UpgradeTo = BokoblinType.Blue;
                break;
            case BokoblinType.Blue:
                UpgradeFrom = BokoblinType.Red;
                UpgradeTo = BokoblinType.Black;
                break;
            case BokoblinType.Black:
                UpgradeFrom = BokoblinType.Blue;
                UpgradeTo = BokoblinType.Stalkoblin;
                break;
            case BokoblinType.Stalkoblin:
                UpgradeFrom = BokoblinType.Black;
                UpgradeTo = BokoblinType.Cursed;
                break;
            case BokoblinType.Cursed:
                UpgradeFrom = BokoblinType.Stalkoblin;
                UpgradeTo = BokoblinType.Silver;
                break;
            case BokoblinType.Silver:
                UpgradeFrom = BokoblinType.Cursed;
                UpgradeTo = BokoblinType.Golden;
                break;
            case BokoblinType.Golden:
                UpgradeFrom = BokoblinType.Silver;
                UpgradeTo = BokoblinType.Golden;
                break;
            default:
                UpgradeFrom = Type;
                UpgradeTo = Type;
                break;
        }
    }

    private static string[] GetEffectiveWeapons()
    {
        return new string[] { "Sword", "Bow", "Bomb" };
    }
    
    public void Eat()
    {
        Console.WriteLine("Bokoblin is eating food");
    }

    public void Sleep()
    {
        Console.WriteLine("Bokoblin is sleeping");
    }
    
    public void SneakedOn()
    {
        Console.WriteLine("Bokoblin can be sneaked on");
    }
}
