using System;
using Zelda.Properties;

namespace Zelda
{
    public class Lynel : Enemy, IBlockable, IRoarable
    {
        public enum LynelType
        {
            Red,
            Blue,
            WhiteMane,
            Silver,
            Golden
        }

        public LynelType Type { get; private set; }
        public LynelType UpgradeFrom { get; private set; }
        public LynelType UpgradeTo { get; private set; }

        public Lynel(LynelType type = LynelType.Red)
            : base("Lynel", "Unknown", "Centaur", CalculateHealth(type), CalculateThreat(type), 10, new string[]{"Sword"})
        {
            Type = type;
            SetUpgradeInfo();
        }

        private void SetUpgradeInfo()
        {
            switch (Type)
            {
                case LynelType.Red:
                    UpgradeFrom = LynelType.Red;
                    UpgradeTo = LynelType.Blue;
                    break;
                case LynelType.Blue:
                    UpgradeFrom = LynelType.Red;
                    UpgradeTo = LynelType.WhiteMane;
                    break;
                case LynelType.WhiteMane:
                    UpgradeFrom = LynelType.Blue;
                    UpgradeTo = LynelType.Silver;
                    break;
                case LynelType.Silver:
                    UpgradeFrom = LynelType.WhiteMane;
                    UpgradeTo = LynelType.Golden;
                    break;
                case LynelType.Golden:
                    UpgradeFrom = LynelType.Silver;
                    UpgradeTo = LynelType.Golden;
                    break;
                default:
                    UpgradeFrom = Type;
                    UpgradeTo = Type;
                    break;
            }
        }

        private static int CalculateHealth(LynelType type)
        {
            switch (type)
            {
                case LynelType.Red:
                    return 2000;
                case LynelType.Blue:
                    return 3000;
                case LynelType.WhiteMane:
                    return 4000;
                case LynelType.Silver:
                    return 5000;
                case LynelType.Golden:
                    return 7500;
                default:
                    return 2000;
            }
        }
        
        private static int CalculateThreat(LynelType type)
        {
            switch (type)
            {
                case LynelType.Red:
                    return 6;
                case LynelType.Blue:
                    return 7;
                case LynelType.WhiteMane:
                    return 1;
                case LynelType.Silver:
                    return 9;
                case LynelType.Golden:
                    return 10;
                default:
                    return 2000;
            }
        }

        public void Roar()
        {
            Console.WriteLine("Lynel roars with force");
        }
        
        public void ShieldBlock()
        {
            Console.WriteLine("Lynel raises its shield to block an attack");
        }
    }

}