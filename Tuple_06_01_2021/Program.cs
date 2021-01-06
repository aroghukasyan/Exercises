using System;

namespace Tuple_06_01_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            var tuple = (5, 3);
            (int, string, double) person = (25, "Aro", 1510.5);
            var (age, name, salary) = (25, "Aro", 1510.2);
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);
            Console.WriteLine(person.Item1);
            Console.WriteLine(person.Item2);
            Console.WriteLine(person.Item3);

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(salary);


        }

    }
}
