using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInCSharp
{
    public class InheritanceIncShrapCompleteExample
    {
        // Base class
        public class Vehicle
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }

            public Vehicle(string brand, string model, int year)
            {
                Brand = brand;
                Model = model;
                Year = year;
            }

            public virtual void DisplayInfo()
            {
                Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}");
            }
        }

        // Derived class 1
        public class Car : Vehicle
        {
            public string Type { get; set; }

            public Car(string brand, string model, int year, string type) : base(brand, model, year)
            {
                Type = type;
            }

            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine($"Type: {Type}");
            }
        }

        // Derived class 2
        public class Truck : Vehicle
        {
            public int LoadCapacity { get; set; }

            public Truck(string brand, string model, int year, int loadCapacity) : base(brand, model, year)
            {
                LoadCapacity = loadCapacity;
            }

            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine($"Load Capacity: {LoadCapacity} tons");
            }
        }

        // Derived class 3
        public class Motorcycle : Vehicle
        {
            public string Style { get; set; }

            public Motorcycle(string brand, string model, int year, string style) : base(brand, model, year)
            {
                Style = style;
            }

            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine($"Style: {Style}");
            }
        }

    }
}
