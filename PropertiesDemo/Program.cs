using System;

namespace PropertiesDemo
{
    // Let's modify this class to not allow Length and Width to be set
    // after the instance is created. 
    class Rectangle
    {
        private double pLength;
        private double pWidth;

        public Rectangle(double Length, double Width)
        {
            pLength = Length;
            pWidth = Width;
        }

        public double GetLength()
        {
            return pLength;
        }

        public double GetWidth()
        {
            return pWidth;
        }

        public double GetArea()
        {
            return pLength * pWidth;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(3.5, 2.6);
            Console.WriteLine($"Rectangle has Length {r1.GetLength()} and Width {r1.GetWidth()}");
            Console.WriteLine(r1.GetArea());
        }
    }
}
