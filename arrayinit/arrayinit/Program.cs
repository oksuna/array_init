using System;

namespace arrayinit
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            for (int i = 0; i <numbers.Length; i++)
            {
                numbers[i] = i + 1;
                Console.WriteLine(numbers[i]);
            }


            Console.WriteLine("Hello Oksana!");
        }
    }
}
