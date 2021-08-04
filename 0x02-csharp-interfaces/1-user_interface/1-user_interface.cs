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
/// Test class
/// </summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }

    public void Interact()
    {
        throw new NotImplementedException();
    }
    public void Collect()
    {
        throw new NotImplementedException();
    }
    public void Break()
    {
        throw new NotImplementedException();
    }
}
