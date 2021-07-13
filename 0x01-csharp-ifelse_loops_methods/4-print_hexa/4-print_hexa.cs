using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
        for (int woot = 0; woot < 99; woot++)
            Console.Write("{0:D} = 0x{0:x}\n", woot);
        }
    }
}
