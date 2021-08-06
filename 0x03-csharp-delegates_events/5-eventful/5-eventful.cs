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
/// The playa's args, playa
/// </summary>
public class CurrentHPArgs : EventArgs
{

    /// <summary>
    /// The playa's health, playa
    /// </summary>
    public readonly float currentHp;

    /// <summary>
    /// Defines a new instance of the <see cref="CurrentHPArgs"/> class.
    /// </summary>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
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
        this.name = name;
        this.status = $"{this.name} is ready to go!";
        if (maxHp <= 0)
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            maxHp = 100.0f;
        }
        this.maxHp = maxHp;
        this.hp = maxHp;
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
        Console.WriteLine($"{this.name} takes {damage} damage!");
        ValidateHP(this.hp - damage);
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

        Console.WriteLine($"{this.name} heals {heal} HP!");
        ValidateHP(this.hp + heal);
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
        OnCheckStatus(new CurrentHPArgs(this.hp));
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
        if (e.currentHp == this.maxHp)
        {
            Console.WriteLine($"{this.name} is in perfect health!");
        }
        else if (e.currentHp >= this.maxHp / 2)
        {
            Console.WriteLine($"{this.name} is doing well!");
        }
        else if (e.currentHp >= this.maxHp / 4 && e.currentHp < this.maxHp / 2)
        {
            Console.WriteLine($"{this.name} isn't doing too great...");
        }
        else if (e.currentHp < this.maxHp / 4 && e.currentHp > 0)
        {
            Console.WriteLine($"{this.name} needs help!");
        }
        else if (e.currentHp == 0)
        {
            Console.WriteLine($"{this.name} is knocked out!");
        }
    }

    /// <summary>
    /// A warning for the playa, playa
    /// </summary>
    private void HPValueWarning(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == 0)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Health has reached zero!");
            Console.ResetColor();
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Health is low!");
            Console.ResetColor();
        }
    }

    /// <summary>
    /// HP warning for the playa, playa
    /// </summary>
    public void OnCheckStatus(CurrentHPArgs e)
    {
        CheckStatus(HPCheck, new CurrentHPArgs(this.hp));

        if (e.currentHp <= (this.hp * 0.25f))
        {
            HPValueWarning(HPCheck, new CurrentHPArgs(this.hp));
        }
    }
}
