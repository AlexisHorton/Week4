using System;

namespace ExceptionDemo
{
    class Program
    {
        static void ArrayFun()
        {
            int[] nums = new int[] { 3, 6, 9 };
            Console.WriteLine(nums[0]);
            Console.WriteLine(nums[1]);
            Console.WriteLine(nums[2]);
            Console.WriteLine(nums[3]); // array out of bounds

        }

        static void Main(string[] args)
        {
            try
            {
                ArrayFun();
            }
            catch (Exception)
            {

                Console.WriteLine("Oops! Something went wrong. Try again later.");
            }
            
        }
    }
}
