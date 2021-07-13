using System;

namespace _12_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int woot = 1; woot < 100; woot++)
            {
            if (woot % 3 == 0)
            Console.Write("Fizz");
            if (woot % 5 == 0)
            Console.Write("Buzz");
            if (woot % 3 != 0 && woot % 5 != 0)
            Console.Write("{0:D}", woot);
            Console.Write(" ");
            }
        Console.WriteLine("Buzz");
        }
    }
}
