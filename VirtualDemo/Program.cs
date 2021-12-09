using System;
using System.Collections.Generic;

namespace VirtualDemo
{

    abstract class Car
    {
        //The word "abstract" means they can't create an instance of this class, 
        // only classes derived from it.

        public string Make;
        public string Model;
        public int GasAmount;

        public virtual void Drive()
        {
            Console.WriteLine("I'm driving!");
        }
    }

    class EconomyCar : Car
    {
        public override void Drive()
        {
            Console.WriteLine("I'm driving slowly!");
        }
    }

    class RaceCar : Car
    {
        public override void Drive()
        {
            Console.WriteLine("I'm driving really fast!");
        }
    }

    class Program
    {
        static void TestTrack(Car testcar)
        {
            Console.WriteLine("\nWe're at the test track!");
            Console.WriteLine($"We're testing a {testcar.Model}!");
            testcar.Drive();
        }
        
        static void Main(string[] args)
        {
            EconomyCar pinto = new EconomyCar();
            pinto.Make = "Ford";
            pinto.Model = "Pinto";
            pinto.GasAmount = 10;
            Console.WriteLine("\nLet's drive the pinto!");
            pinto.Drive();

            RaceCar f1 = new RaceCar();
            f1.Make = "Formula";
            f1.Model = "One";
            f1.GasAmount = 30;
            Console.WriteLine("\nLet's drive the formula!");
            f1.Drive();

            List<Car> cars = new List<Car>();
            cars.Add(pinto);
            cars.Add(f1);

            Car mycar;
            mycar = pinto;
            Console.WriteLine("\nmycar.Model points to the Pinto:");
            Console.WriteLine(mycar.Model);
            mycar.Drive(); // The code called the right version of Drive. This is "polymorphism"

            mycar = f1;
            Console.WriteLine("\nmycar now points to the One:");
            Console.WriteLine(mycar.Model);
            mycar.Drive();

            TestTrack(pinto);
            TestTrack(f1);

        }
    }
}
