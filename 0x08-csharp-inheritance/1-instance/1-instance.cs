using System;

/// <summary>
/// Objectively speaking
/// </summary>
class Obj
{
    /// <summary>
    /// Is we arr is we ay
    /// </summary>
    public static bool IsInstanceOfArray(object obj)
    {
        if (!obj.GetType().IsArray)
        {
        return false;
        }
    return true;
}}
