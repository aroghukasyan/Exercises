using System;

namespace Array_22._12._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array_test = new int[10];
            char[] array_char_test = new char[] { 'a','a','c','d' };
            int temp = 0;
            foreach(char i in array_char_test)
            {
                Console.WriteLine(i);
            }
            foreach(int i in array_test)
            {
                array_test[i] = ++temp;//++;
                Console.WriteLine(i);        
            }
            for (int i = 0; i < 10; i++)            
            {
                Console.Write(array_test[i] + " ");
            }
        }
    }
}
