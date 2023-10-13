using Zelda.Properties;
using System;

namespace Zelda
{
    public class YigaFootSoldier: Enemy, ISneakable, IEatable, ISwimmable, ITeleportable
    {
        public YigaFootSoldier()
            : base("Yiga Foot Soldier", "Male", "Sheikah", 150, 3, 12, new string[] {"Any"})
        {
        }
        
        public void Teleport()
        {
            Console.WriteLine("the Yiga Foot Soldier teleports to a different location");
        }

        public void SneakedOn()
        {
            Console.WriteLine("the Yiga Foot Soldier can be sneaked on");
        }

        public void Eat()
        {
            Console.WriteLine("the Yiga Foot Soldier is eating");
        }

        public void Swim()
        {
            Console.WriteLine("the Yiga Foot Soldier swims");
        }
    }
}