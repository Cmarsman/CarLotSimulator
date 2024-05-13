using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var carLotOne = new CarLot();

            var carOne = new Car();

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

            carLotOne.ParkingLot.Add(carTwo);


            var carThree = new Car(2021, "Toyota", "Camry", "vroom", "honk", false);
            
            carLotOne.ParkingLot.Add(carThree);

            carLotOne.CheckCars();
            
            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            
            











        }
            
            
    }
}
