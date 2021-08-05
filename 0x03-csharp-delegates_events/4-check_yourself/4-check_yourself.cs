﻿using System;


/// <summary>
/// The playa's helth and such, playa
/// </summary>
public delegate float CalculateHealth(float health);

/// <summary>
/// Just what the playa doin'
/// </summary>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// The playa's args, playa
/// </summary>
public class CurrentHPArgs : EventArgs
{
    /// <summary>
    /// The playa's health, playa
    /// </summary>
    public readonly float currentHP;

    /// <summary>
    /// Defines a new instance of the <see cref="CurrentHPArgs"/> class.
    /// </summary>
    public CurrentHPArgs(float newHP)
    {
        this.currentHP = newHP;
    }
}

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
    private string status { get; set; }

    /// <summary>
    /// The playa's event handler for the health calculation
    /// </summary>
    public event EventHandler<CurrentHPArgs> HPCheck;

    /// <summary>
    /// Sudo me a playa, playa (constructor)
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
        this.status = $"{this.name} is ready to go!";
        HPCheck += CheckStatus;
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
    public void ValidateHP(float newHp)
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
        CheckStatus(HPCheck, new CurrentHPArgs(this.hp));
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

    /// <summary>
    /// The playa's event handler for the health calculation
    /// </summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHP == this.maxHp)
        {
            Console.WriteLine($"{this.name} is in perfect health!");
        }
        else if (e.currentHP >= this.maxHp / 2)
        {
            Console.WriteLine($"{this.name} is doing well!");
        }
        else if (e.currentHP >= this.maxHp / 4 && e.currentHP < this.maxHp / 2)
        {
            Console.WriteLine($"{this.name} isn't doing too great. . .");
        }
        else if (e.currentHP < this.maxHp / 4 && e.currentHP > 0)
        {
            Console.WriteLine($"{this.name} needs help!");
        }
        else if (e.currentHP == 0)
        {
            Console.WriteLine($"{this.name} is knocked out!");
        }
    }
}
