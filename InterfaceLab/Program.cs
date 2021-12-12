using System;

namespace InterfaceLab
{
    interface ICountable
    {
        void IncrementCount();
        void ResetCount();
        int GetCount();
        String GetCountString();
    }

    class Alligator : ICountable
    {
        public int Count;

        public int GetCount()
        {
            return Count;
        }

        public string GetCountString()
        {
            return Count.ToString();
        }

        public void IncrementCount()
        {
           Count++;
        }

        public void ResetCount()
        {
            Count = 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
