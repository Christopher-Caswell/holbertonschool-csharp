using System;

/// <summary>
/// Objectifies
/// </summary>
class Obj
{
    /// <summary>
    /// Is we or is we int
    /// </summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj.GetType() != typeof(int))
        {
        return false;
        }

        return true;
    }
}
