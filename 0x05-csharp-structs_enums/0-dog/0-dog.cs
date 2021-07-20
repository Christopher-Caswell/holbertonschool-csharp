using System;

class Program
{
    public enum Rating
    {
        Good,
        Great,
        Excellent
    }

    static void Main(string[] args)
    {
        Rating rating;

        rating = Rating.Great;

        Console.WriteLine("Score: " + rating);
        Console.WriteLine("Score: " + (int)rating);
    }
}
