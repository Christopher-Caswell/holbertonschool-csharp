using System;


/// <summary>
/// The playa's helth and such, playa
/// </summary>
public delegate float CalculateHealth(float health);

/// <summary>
/// Just what the playa doin'
/// </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// Enum for playa
/// </summary>
public enum Modifier
{
    /// <summary>
    /// weak
    /// </summary>
    Weak,
    /// <summary>
    /// normal
    /// </summary>
    Base,
    /// <summary>
    /// strong
    /// </summary>
    Strong
}

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
    /// The playa's ability to take a caning
    /// </summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0.0f)
        {
            damage = 0.0f;
        }
        ValidateHP(this.hp - damage);
        Console.WriteLine($"{this.name} takes {damage} damage!");
    }

    /// <summary>
    /// The playa gotta heal
    /// </summary>
    public void HealDamage(float heal)
    {
        if (heal < 0.0f)
        {
            heal = 0.0f;
        }

        ValidateHP(this.hp + heal);
        Console.WriteLine($"{this.name} heals {heal} HP!");
    }

    /// <summary>
    /// Tell me how much health you have, playa
    /// </summary>
    public float ValidateHP(float newHp)
    {
        if (newHp < 0.0f)
        {
            this.hp = 0.0f;
        }
        else if (newHp > this.maxHp)
        {
            this.hp = this.maxHp;
        }
        else
        {
            this.hp = newHp;
        }
        return this.hp;
    }

    
    /// <summary>
    /// Modify the playa, playa
    /// </summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier is Modifier.Weak)
        {
            return baseValue *= 0.5f;
        }
        if (modifier is Modifier.Strong)
        {
            return baseValue *= 1.5f;
        }
        else
        {
            return baseValue;
        }
    }
}
