using System;


class Array
{
    public static int[] CreatePrint(int size)
    {
        int[] noot;

        if (size < 0) {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        
        noot = new int[size];

        for (int x = 0; x < size; x++) {
            Console.Write("{0:D}", x);
            if (x != size - 1)
                Console.Write(" ");
            noot[x] = x;
        }
        Console.WriteLine();

        return noot;
    }
}
