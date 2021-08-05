using System;

/// <summary>
/// The playa, playa
/// </summary>
public class Player
{
    private string name { get; set; }
    private float maxHp { get; set; }
    private float hp { get; set; }


    /// <summary>
    /// Sudo me a playa, playa
    /// </summary>
    public Player(string name="Player", float maxHp=100.0f)
    {
        if (name != null)
            this.name = name;
        if (maxHp > 0.0f)
        {
            this.maxHp = maxHp;
            this.hp = maxHp;
        }
        else
        {
            maxHp = 100.0f;
            this.hp = 100.0f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
    }
    /// <summary>
    /// Construction of sinew and bone. . . playa?
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }

    /// <summary>
    /// The playa's helth and such, playa
    /// </summary>
    public delegate float CalculateHealth();

    /// <summary>
    /// The playa's ability to take a caning
    /// </summary>
    public void TakeDamage(float damage)
    {
        if (damage > 0.0f)
        {
            this.hp -= damage;
            Console.WriteLine($"{this.name} took {damage} damage!");
        }
        else
        {
            Console.WriteLine($"{this.name} took 0 damage!");
        }
    }

    /// <summary>
    /// The playa gotta heal
    /// </summary>
    public void HealDamage(float heal)
    {
        if (heal < 0.0f)
        {
            Console.WriteLine($"{this.name} heals 0 HP!");
        }
        else
        {
            this.hp += heal;
            Console.WriteLine($"{this.name} heals {heal} HP!");
        }
    }
}
