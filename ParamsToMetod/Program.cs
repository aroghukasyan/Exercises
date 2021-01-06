using System;

namespace ParamsToMetod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Metod("text", 10, 1, 2, 3, 4, 5, 6, 7, 8, 9);
        }

        public static void Metod(string str, int a, params int[] array)
        {
            int sum = 0;
            foreach(int i in array)
            {
                sum += i;
            }
            Console.WriteLine($"Parameter 1) {str}\n Parameter 2) {a}\n Array sum is {sum}");
        }
    }
}
