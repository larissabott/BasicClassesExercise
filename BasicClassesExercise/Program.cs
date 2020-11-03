using System;
using System.Collections.Generic;
using System.Xml;

namespace BasicClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Honda";
            myCar.Model = "CRV";
            myCar.Year = 2002;

            var chevy = new Car()
            {
                Make = "Chevy",
                Model = "Blaze",
                Year = 2003
            };

            var mazda = new Car("Mazda", "CX-5", 2016);

            var CarList = new List<Car>() { myCar, mazda, chevy };

            foreach(var vehicle in CarList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year}");
            }
        }
    }
}
