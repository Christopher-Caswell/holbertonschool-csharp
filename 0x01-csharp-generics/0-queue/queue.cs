using System;

/// <summary>
/// Generic queue class.
/// </summary>
class Queue<T>
{
    /// <summary>
    /// Return Queue type.
    /// </summary>
    public Type CheckType()
    {
        return typeof(T);
    }
}
