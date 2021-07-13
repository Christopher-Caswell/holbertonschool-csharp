using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int woot = 0; woot < 8; woot++) {
            for (int noot = woot + 1; noot < 10; noot++) {
                Console.Write("{0:D}{1:D}, ", woot, noot);
            }
        }
        Console.WriteLine("89");
        }
    }
}
