using System;

namespace Lab1
{
    static internal class Print
    {
        public static void PrintInt32Array(in int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write($"{array[i]}, ");
            }
            if (array.Length > 0 )
            {
                Console.Write(array[array.Length - 1]);
            }
            Console.Write("]\n");
        }
    }
}
