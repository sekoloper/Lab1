using System;

namespace Lab1
{
    static internal class InputValidation
    {
        public static void GetInt32(out int num, in string message)
        {
            Console.WriteLine(message);
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine(message);
            }
        }

        public static void GetInt32WithArea(out int num, in string message, in int lowerEdge, in int upperEdge)
        {
            do
            {
                GetInt32(out num, message);
            }
            while (num < lowerEdge || num > upperEdge);
        }

        public static void GetInt32Array(out int[] array)
        {
            Console.WriteLine("Все вами введённые числа не должны превышать размерность int (2.147.483.647 по модулю)");
            int arrSize, num;
            GetInt32(out arrSize, "Введите размер массива: ");
            array = new int[arrSize];
            for (int i = 0; i < arrSize; i++)
            {
                GetInt32(out array[i], $"Введите элемент массива под номером {i}: ");
            }
        }

        public static void GetChar(out char ch, in string message)
        {
            Console.WriteLine(message);
            while (!char.TryParse(Console.ReadLine(), out ch))
            {
                Console.WriteLine(message);
            }
        }
    }
}
