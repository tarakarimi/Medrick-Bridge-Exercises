using Zelda.Properties;
using System;

namespace Zelda
{
    public class Lizalfos : Enemy, ISwimmable, IEatable
    {
        public enum LizalfosType
        {
            Green,
            Blue,
            Black,
            Stalizalfos,
            Cursed,
            FireBreath,
            IceBreath,
            Electric,
            Silver,
            Golden
        }

        public LizalfosType Type { get; private set; }

        public Lizalfos(LizalfosType type = LizalfosType.Green)
            : base("Lizalfos", "Unknown", "Lizard", CalculateHealth(type), 6, 5, new string[] { "Bow" })
        {
            Type = type;
            SetUpgradeInfo();
        }
        
        public override void Attack()
        {
            switch (Type)
            {
                case LizalfosType.FireBreath:
                    Console.WriteLine($"FireBreath Lizalfos breathes fire for {Damage} damage");
                    break;
                case LizalfosType.IceBreath:
                    Console.WriteLine($"IceBreath Lizalfos breathes ice for {Damage} damage");
                    break;
                case LizalfosType.Electric:
                    Console.WriteLine($"Electric Lizalfos releases electric shockwaves for {Damage} damage");
                    break;
                default:
                    base.Attack();
                    break;
            }
        }

        private void SetUpgradeInfo()
        {
            switch (Type)
            {
                case LizalfosType.Green:
                    Type = LizalfosType.Blue;
                    break;
                case LizalfosType.Blue:
                    Type = LizalfosType.Black;
                    break;
                case LizalfosType.Black:
                    Type = LizalfosType.Stalizalfos;
                    break;
                case LizalfosType.Stalizalfos:
                    Type = LizalfosType.Cursed;
                    break;
                case LizalfosType.Cursed:
                    Type = LizalfosType.FireBreath;
                    break;
                case LizalfosType.FireBreath:
                    Type = LizalfosType.IceBreath;
                    break;
                case LizalfosType.IceBreath:
                    Type = LizalfosType.Electric;
                    break;
                case LizalfosType.Electric:
                    Type = LizalfosType.Silver;
                    break;
                case LizalfosType.Silver:
                    Type = LizalfosType.Golden;
                    break;
                case LizalfosType.Golden:
                    Console.WriteLine("Golden Lizalfos is already at the highest upgrade");
                    break;
            }
        }
        
        private static int CalculateHealth(LizalfosType type)
        {
            switch (type)
            {
                case LizalfosType.Green:
                    return 30;
                case LizalfosType.Blue:
                    return 120;
                case LizalfosType.Stalizalfos:
                    return 1;
                case LizalfosType.Silver:
                    return 864;
                case LizalfosType.Golden:
                    return 1296;
                default:
                    return 288;
            }
        }

        public void Swim()
        {
            Console.WriteLine("Lizalfos is swimming in the water");
        }

        public void Eat()
        {
            Console.WriteLine("Lizalfos is Eating food");
        }
        
    }

}