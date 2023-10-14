using Zelda.Properties;
using System;

namespace Zelda
{
    public class Pebblit : Enemy, IRollable
    {
        public enum PebblitType
        {
            Stone,
            Igneo,
            Frost
        }

        public PebblitType Type { get; private set; }

        public Pebblit(PebblitType type = PebblitType.Stone)
            : base("Pebblit", "Unknown", "Rock", 8, CalculateThreat(type), 6, GetEffectiveWeapons(type))
        {
            Type = type;
        }

        private static int CalculateThreat(PebblitType type)
        {
            switch (type)
            {
                case PebblitType.Frost:
                    return 2;
                default:
                    return 1;
            }
        }

        private static string[] GetEffectiveWeapons(PebblitType type)
        {
            switch (type)
            {
                case PebblitType.Stone:
                    return new string[] {"Iron Sledgehammer", "Cobble Crusher", "Stone Smasher", "Boulder Breaker", "Drillshaft", "Ancient Arrow", "Bomb Arrow", "Remote Bombs"};
                default:
                    return new string[] {"Iron Sledgehammer", "Bombs"};
            }
        }

        public void Roll()
        {
            Console.WriteLine("Pebblit rolls around.");
        }
    }

}