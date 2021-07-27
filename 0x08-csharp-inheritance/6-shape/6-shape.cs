using System;

/// <summary>
/// Shapely
/// </summary>
class Shape {
    public virtual int Area() {
        throw new NotImplementedException("Area() is not implemented");
    }
}

/// <summary>
/// Rectangle class
/// </summary>
class Rectangle : Shape
{
    private int width;
    private int height;

    /// <summary>
    /// Constructor for width
    /// </summary>
    public int Width { 
        get { return width; }

        set {
        if (value < 0) throw new ArgumentOutOfRangeException("value", "Width must be greater than or equal to 0.");
        else width = value;}
    }
    /// <summary>
    /// Constructor for height
    /// </summary>
    public int Height {
        get { return height; }

        set {
        if (value < 0) throw new ArgumentOutOfRangeException("value", "Height must be greater than or equal to 0.");
        else height = value;}
    }
}
