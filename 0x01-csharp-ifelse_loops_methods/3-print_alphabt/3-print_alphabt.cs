using System;

namespace _3_print_alphabt
{
class Program
{
static void Main(string[] args)
{
char woot;
for (woot = 'a'; woot <= 'z'; woot++)
if (woot != 113 && woot != 101)
Console.Write("{0}", woot);
}
}
}
