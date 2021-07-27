using System;

/// <summary>
/// Objection
/// </summary>
class Obj
{
    /// <summary>
    /// Object subjugation, subject to terms and conditions
    /// </summary>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
        {
        return true;
        }

        return false;
    }
}
