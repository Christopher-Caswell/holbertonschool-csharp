using System;

abstract class Base
{
    public string name { get; set; }

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
    public Door(string name="Door")
    {
        this.name = name;
    }
    public void Interact()
    {
        Console.WriteLine($"You try to open the {name}. It's locked.");
    }
}
