using System;
using System.Collections.Generic;
using System.Text;

namespace BasicClassesExercise
{
    public class Car
    {
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public Car() //- a special member method that has the same as its class
        {
        }

        //fields
        //properties
        //methods

        //create a make property of tyoe string that is public
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }


    }
} 
    
