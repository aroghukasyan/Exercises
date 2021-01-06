using System;

namespace Metodes_27_12_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Aro.\n Write array elements");
            array_initialize();
            Console.WriteLine("Sum of array elements is - " + sumOfArray(Array));
            Console.WriteLine("largest of array elements is - " + largestOfArray(Array));
            Console.WriteLine("Smaalest of array elements is - " + smalestOfArray(Array));
        }

        public static int[] Array = new int[10];
        public static void array_initialize() 
        {
            for(int i = 0; i < 10; i++)
            {
                Array[i]  = int.Parse(Console.ReadLine());
            }
        }
        public static int sumOfArray(int[] array)
        {
            int sum = 0;
            foreach(int l in array)
            {
                sum += l;
            }
            return sum;
        }
        public static int largestOfArray(int[] array)
        {
            int temp = 0;
            for(int i = 0; i < array.Length; i++)
            {
                temp = (temp > array[i]) ? temp: array[i];
            }
            return temp;
        }
        public static int smalestOfArray(int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                temp = (temp < array[i]) ? temp : array[i];
            }
            return temp;
        }

    }
}
