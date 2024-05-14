using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLotOne = new CarLot();

            Console.WriteLine($"Current number of cars in the car lot: {CarLot.numberOfCars}");

            var carOne = new Car();
            Console.WriteLine($"Current number of cars in the car lot: {CarLot.numberOfCars}");

            carOne.Make = "Chrysler";
            carOne.Model = "Thunderbolt Roadster";
            carOne.Year = 1941;
            carOne.EngineNoise = "purr";
            carOne.HonkNoise = "beep";
            carOne.IsDriveable = true;

            carLotOne.ParkingLot.Add(carOne);

            var carTwo = new Car()
            {
                Make = "Mercury",
                Model = "Club Coupe",
                Year = 1940,
                EngineNoise = "rumble",
                HonkNoise = "honk honk",
                IsDriveable = true

                
            };
            Console.WriteLine($"Current number of cars in the car lot: {CarLot.numberOfCars}");

            carLotOne.ParkingLot.Add(carTwo);


            var carThree = new Car(2021, "Toyota", "Camry", "vroom", "honk", false);
            Console.WriteLine($"Current number of cars in the car lot: {CarLot.numberOfCars}");

            carLotOne.ParkingLot.Add(carThree);

            carLotOne.CheckCars();
            
            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            
            











        }
            
            
    }
}
