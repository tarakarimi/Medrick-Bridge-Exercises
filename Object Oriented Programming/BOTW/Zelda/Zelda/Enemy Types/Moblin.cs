using System;
using Zelda.Properties;

namespace Zelda
{
    public class Moblin : Enemy, ISneakable, IEatable, IBlockable
    {
        public enum MoblinType
        {
            Red,
            Blue,
            Black,
            Stalmoblin,
            Cursed,
            Silver,
            Golden
        }

        public MoblinType Type { get; private set; }
        public MoblinType UpgradeFrom { get; private set; }
        public MoblinType UpgradeTo { get; private set; }

        public Moblin(MoblinType type = MoblinType.Blue)
            : base("Moblin", "Unknown", "Goblin", CalculateHealth(type), 4, 12, GetEffectiveWeapons())
        {
            Type = type;
            SetUpgradeInfo();
        }
        
        private static int CalculateHealth(MoblinType type)
        {
            switch (type)
            {
                case MoblinType.Red:
                    return 72;
                case MoblinType.Blue:
                    return 144;
                case MoblinType.Black:
                    return 360;
                case MoblinType.Silver:
                    return 1080;
                case MoblinType.Golden:
                    return 2048;
                default:
                    return 30;
            }
        }
        
        private void SetUpgradeInfo()
        {
            switch (Type)
            {
                case MoblinType.Red:
                    UpgradeFrom = MoblinType.Red;
                    UpgradeTo = MoblinType.Blue;
                    break;
                case MoblinType.Blue:
                    UpgradeFrom = MoblinType.Red;
                    UpgradeTo = MoblinType.Black;
                    break;
                case MoblinType.Black:
                    UpgradeFrom = MoblinType.Blue;
                    UpgradeTo = MoblinType.Stalmoblin;
                    break;
                case MoblinType.Stalmoblin:
                    UpgradeFrom = MoblinType.Black;
                    UpgradeTo = MoblinType.Cursed;
                    break;
                case MoblinType.Cursed:
                    UpgradeFrom = MoblinType.Stalmoblin;
                    UpgradeTo = MoblinType.Silver;
                    break;
                case MoblinType.Silver:
                    UpgradeFrom = MoblinType.Cursed;
                    UpgradeTo = MoblinType.Golden;
                    break;
                case MoblinType.Golden:
                    UpgradeFrom = MoblinType.Silver;
                    UpgradeTo = MoblinType.Golden;
                    break;
                default:
                    UpgradeFrom = Type;
                    UpgradeTo = Type;
                    break;
            }
        }
        
        private static string[] GetEffectiveWeapons()
        {
            return new string[] { "Sword", "Bow" };
        }

        public void ShieldBlock()
        {
            Console.WriteLine("Moblin raises its shield to block an attack");
        }
        
        public void Eat()
        {
            Console.WriteLine("Moblin is eating food");
        }

        public void Sleep()
        {
            Console.WriteLine("Moblin is sleeping");
        }
    
        public void SneakedOn()
        {
            Console.WriteLine("Moblin can be sneaked on");
        }
    }

}