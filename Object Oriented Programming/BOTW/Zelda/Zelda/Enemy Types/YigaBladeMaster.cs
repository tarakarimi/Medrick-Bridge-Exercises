using System;
using Zelda.Properties;

public class YigaBlademaster : Enemy, ISneakable, IEatable, ISwimmable, ITeleportable, IAssassinate
{
    public YigaBlademaster()
        : base("Yiga Blademaster", "Male", "Sheikah", 300, 6, 15, new string[] {"Any"})
    {
    }

    public void Assassinate()
    {
        Console.WriteLine("Yiga Blademaster performs an assassination");
    }
    
    public void Teleport()
    {
        Console.WriteLine("Yiga Blademaster teleports to a different location");
    }

    public void SneakedOn()
    {
        Console.WriteLine("Yiga Blademaster can be sneaked on");
    }

    public void Eat()
    {
        Console.WriteLine("Yiga Blademaster is eating");
    }

    public void Swim()
    {
        Console.WriteLine("Yiga Blademaster swims");
    }
}