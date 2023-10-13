using System;
using Zelda.Properties;

namespace Zelda
{
    public class Wizzrobe : Enemy, IFlyable, ITeleportable
    {
        public enum WizzrobeType
        {
            Fire,
            Ice,
            Electric,
            Meteo,
            Blizzrobe,
            Thunder
        }

        public WizzrobeType Type { get; private set; }

        public Wizzrobe(WizzrobeType type = WizzrobeType.Fire)
            : base("Wizzrobe", "Unknown", "Wizard", 20, CalculateThreat(type), 8, GetEffectiveWeapons(type))
        {
            Type = type;
        }
        
        private static int CalculateThreat(WizzrobeType type)
        {
            switch (type)
            {
                case WizzrobeType.Fire:
                case WizzrobeType.Ice:
                case WizzrobeType.Electric:
                    return 5;
                case WizzrobeType.Meteo:
                case WizzrobeType.Blizzrobe:
                case WizzrobeType.Thunder:
                    return 6;
                default:
                    return 5;
            }
        }

        private static string[] GetEffectiveWeapons(WizzrobeType type)
        {
            switch (type)
            {
                case WizzrobeType.Ice:
                    return new string[] { "Flame Lantern", "Flame Blade", "Fire Arrow" };
                case WizzrobeType.Blizzrobe:
                    return new string[] { "Fire Weapons"};
                default:
                    return new string[] { "Ranged"};
            }
        }

        public void Teleport()
        {
            Console.WriteLine("Wizzrobe teleports");
        }

        public override void Attack()
        {
            Console.WriteLine($"Wizzrobe casts a spell for {Damage} damage");
        }

        public void Fly()
        {
            Console.WriteLine("Wizzrobe is flying.");
        }
    }

}