using System;

namespace algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] newNumbers = InsertElement(10, numbers, 3);
            ReverseArray(numbers);
            foreach (int num in newNumbers)
                Console.WriteLine("{0}", num);
        }

        public static int[] InsertElement(int x, int[] numbers, int pos)
        {
            int length = numbers.Length;
            int[] newNumbers = new int[length + 1];

            for (int i = 0; i < length; i++)
            {
                if (i >= pos)
                    newNumbers[i + 1] = numbers[i];
                else
                    newNumbers[i] = numbers[i];
            }

            newNumbers[pos] = x;

            return newNumbers;
        }

        public static void ReverseArray(int[] numbers)
        {
            int length = numbers.Length;

            for (int i = 0; i < length / 2; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[length - i - 1];
                numbers[length - i - 1] = temp;
            }
        }
    }
}
