using System;

namespace PassingParametersByValueAndByReferenceToMetode_04_01_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            metodByValue(x);
            Console.WriteLine("x is " + x);
            metodeByReference(ref x);
            Console.WriteLine("x is " + x);
        }

        

        public static void metodByValue(int x)
        {
            Console.WriteLine("metod by Value  " + (x + 5) );
        }
        public static void metodeByReference(ref int x)
        {
            x += 10;
            Console.WriteLine("metod by Value  " + x);
        }
    }
}
