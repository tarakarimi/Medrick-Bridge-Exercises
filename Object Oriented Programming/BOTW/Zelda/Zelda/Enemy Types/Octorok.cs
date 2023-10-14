using System;

namespace Zelda
{
    public class Octorok : Enemy
    {
        public enum OctorokType
        {
            Water,
            Forest,
            Rock,
            Snow,
            Treasure,
            Sky
        }

        public OctorokType Type { get; private set; }

        public Octorok(OctorokType type = OctorokType.Water)
            : base("Octorok", "Unknown", "Octorok", 10, CalculateThreat(type), 2, new string[] { "Ranged Weapons" })
        {
            Type = type;
        }

        private static int CalculateThreat(OctorokType type)
        {
            switch (type)
            {
                case OctorokType.Water:
                case OctorokType.Forest:
                    return 1;
                case OctorokType.Rock:
                case OctorokType.Snow:
                    return 2;
                case OctorokType.Treasure:
                    return 3;
                case OctorokType.Sky:
                    return 0;
                default:
                    return 1;
            }
        }

        public override void Attack()
        {
            Console.WriteLine($"Octorok attacks by throwing rocks for {Damage} damage!");
        }
        
        public void Hide()
        {
            Console.WriteLine("Octorok hides in its shell.");
        }
    }

}