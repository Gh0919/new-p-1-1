using System;

namespace new_p_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[x];
            for (int i = 0; i < x; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                int minIndex = FindMinInex(numbers, i);
                int temp = numbers[minIndex];
                numbers[minIndex] = numbers[i];
                numbers[i] = temp;
            }
            Print(numbers);
        }
        public static void Print(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        public static int FindMinInex(int[]numbers, int startIndex)
        {
            if (startIndex>=numbers.Length)
            {
                return -1;
            }
            int min = numbers[startIndex];
            int index = startIndex;
            for (int i = startIndex; i < numbers.Length; i++)
            {
                if (min > numbers[i])
                {
                    min = numbers[i];
                    index = i;
                }
            }
            return index;

        }
    }
}
