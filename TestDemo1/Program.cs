using System;

namespace TestDemo1
{
    class Program
    {
        //Write a function that reverses a string.
        static string Reverse(string str)
        {
            if (str == null)
            {
                return null;
            }

            string result = "";
            for (int i = str.Length -1; i >= 0; i--)
            {
                result += str[i];
            }
            return result;
        }

        static void Main(string[] args)
        {

            string test1 = "hello";
            string result1 = Reverse(test1);  // Expect olleh
            if (result1 == "olleh")
            {
                Console.WriteLine("Test1 passed!");
            }
            else
            {
                Console.WriteLine($"Test1 failed! Expected olleh but actual was {result1}");
            }

            string test2 = "";
            string result2 = Reverse(test2);
            if (result2 == "")
            {
                Console.WriteLine("Test1 passed!");
            }
            else
            {
                Console.WriteLine($"Test1 failed! Expected empty string but actual was {result2}");
            }

            string test3 = null;
            try
            {
                string result3 = Reverse(test3);
                if (result2 == "")
                {
                    Console.WriteLine("Test1 passed!");
                }
                else
                {
                    Console.WriteLine($"Test1 failed! Expected null but actual was {result3}");
                }
            }
        }
    }
}
