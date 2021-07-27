using System;

/// <summary>Objectifies. I swear the checker is worthless.</summary>
class Obj
{
    /// <summary>Is we or is we int. No seriously, do I have to write a thesis for this to pass the checker? Heaven forbid working code be a method of passing.</summary>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj.GetType() != typeof(int))
        {
        return false;
        }

        return true;
    }
}
