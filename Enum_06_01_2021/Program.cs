using System;

namespace Enum_06_01_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            days day;
            day = (days)1;
            Console.WriteLine(day);
            
        }
        enum days
        {
            Mondey = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Freday,
            Saturday,
            Sanday,
        }
    }
}
