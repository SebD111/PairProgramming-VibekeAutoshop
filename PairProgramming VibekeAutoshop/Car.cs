using System;
using System.Collections.Generic;
using System.Text;

namespace PairProgramming_VibekeAutoshop
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car()
        {
        }

        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        public int GetAge()
        {
            return DateTime.Now.Year - Year;
        }

        public override string ToString()
        {
            return $"{Year} {Brand} {Model}";
        }

        public bool IsVintage()
        {
            return GetAge() > 25;
        }
    }
}
