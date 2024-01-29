// See https://aka.ms/new-console-template for more information
using static InheritanceInCSharp.InheritanceIncShrapCompleteExample;

Car car = new Car("Toyota", "Camry", 2022, "Sedan");
Truck truck = new Truck("Ford", "F-150", 2020, 2);
Motorcycle motorcycle = new Motorcycle("Honda", "CBR500R", 2021, "Sport");

Console.WriteLine("Car Information:");
car.DisplayInfo();
Console.WriteLine();

Console.WriteLine("Truck Information:");
truck.DisplayInfo();
Console.WriteLine();

Console.WriteLine("Motorcycle Information:");
motorcycle.DisplayInfo();
Console.WriteLine();
