using System;

/// <summary>
/// Base
/// </summary>
public abstract class Base
{
    /// <summary>
    /// Attribute name
    /// </summary>
    public string name { get; set; }

    /// <summary>
    /// Method string override
    /// </summary>
    public override string ToString()
    {
        return $"{this.name} is a {this.GetType()}";
    }
}

/// <summary>
/// Sudo me a do
/// </summary>
interface IInteractive
{
    void Interact();
}

/// <summary>
/// How broken tho
/// </summary>
interface IBreakable
{
    int durability { get; set; }
    void Break();
}

/// <summary>
/// A bool of collectibility
/// </summary>
interface ICollectable
{
    bool isCollected { get; set; }
    void Collect();
}

/// <summary>
/// Door class
/// </summary>
class Door : Base, IInteractive
{
    /// <summary>
    /// Constructor
    /// </summary>
    public Door(string name="Door")
    {
        this.name = name;
    }
    /// <summary>
    /// Method Interact
    /// </summary>
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}
/// <summary>
/// Decoration class
/// </summary>
class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// Quest Bool
    /// </summary>
    public bool isQuestItem { get; set; }

    /// <summary>
    /// Durability base
    /// </summary>
    public int durability { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public Decoration(string name="Decoration", int durability=1, bool isQuestItem=false)
    {
        this.name = name;
        this.durability = durability;
        this.isQuestItem = isQuestItem;
    }

    /// <summary>
    /// Interact method
    /// </summary>
    public void Interact()
    {
        if (this.durability <= 0)
        {
            Console.WriteLine($"The {name} has been broken.");
        }
        if (this.isQuestItem == true)
        {
            Console.WriteLine($"You look at the {name}. There's a key inside.");
        }
        if (this.isQuestItem == false)
        {
            Console.WriteLine($"You look at the {name}. Not much to see here.");
        }
    }


    /// <summary>
    /// Break method
    /// </summary>
    public void Break()
    {
        this.durability--;

        if (this.durability > 0)
        {
            Console.WriteLine($"You hit the {name}. It cracks.");
        }
        if (this.durability == 0)
        {
            Console.WriteLine($"You smash the {name}. What a mess.");
        }
        else
        {
            Console.WriteLine($"The {name} is already broken.");
        }
    }
}
