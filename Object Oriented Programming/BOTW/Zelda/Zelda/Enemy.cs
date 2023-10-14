using System;

public class Enemy
{
    public string Name { get; private set; }
    public string Gender { get; private set; }
    public string Race { get; private set; }
    public int Health { get; private set; }
    public int Threat { get; private set; } // out of 10
    public int Damage { get; private set; }
    public virtual string[] EffectiveWeapons { get; } 
    
    public Enemy(string name = "Unknown", string gender = "Unknown", string race = "Unknown", int health = 100, 
                int threat = 10, int damage = 10, string[] effectiveWeapons = null)
    {
        Name = name;
        Gender = gender;
        Race = race;
        Health = health;
        Threat = threat;
        Damage = damage;
        EffectiveWeapons = effectiveWeapons ?? Array.Empty<string>();
    }
    
    public virtual void Attack()
    {
        Console.WriteLine($"{Name} attacks for {Damage} damage");
    }
    
    public virtual void TakeDamage(int amount)
    {
        Health -= amount;
        Console.WriteLine($"{Name} takes {amount} damage. Remaining health: {Health}");
    }
    
    public virtual void Move(double speed)
    {
        Console.WriteLine($"{Name} is moving at speed {speed}.");
    }
    
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Gender: {Gender}");
        Console.WriteLine($"Race: {Race}");
        Console.WriteLine($"Health: {Health}");
        Console.WriteLine($"Threat Level: {Threat}/10");
        Console.WriteLine($"Effective Weapons: {string.Join(", ", EffectiveWeapons)}");
    }
}