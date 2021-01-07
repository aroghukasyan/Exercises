using System;

namespace ReferenceStackAndHeap_07_01_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person { name = "Tom", age = 23 };
            //ChangePerson(ref p);

            //Console.WriteLine("main " + p.name); // Alice
            //Console.WriteLine("main " + p.age); // 23

            Person p = new Person { name = "Aro", age = 25 };
             p = method();
            Console.WriteLine("main " + p.name);
            Console.WriteLine("main " + p.age);
        }

        static Person method( )
        {
            Person p = new Person { name = "karen", age = 24 };
            Console.WriteLine($"method { p.name} {p.age}");
           
            return p;
        }

        static void ChangePerson(ref Person person)
        {
            // сработает
            person.name = "Alice";
            // сработает только в рамках данного метода
            person = new Person { name = "Bill", age = 45 };
            Console.WriteLine(person.name); // Bill
        }
    }
    class Person
    {
        public string name;
        public int age;
    }
}

