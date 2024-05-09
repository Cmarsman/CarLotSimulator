using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        { 
            var carOne = new Car();

            carOne.Make = "Chrysler";
            carOne.Model = "Thunderbolt Roadster";
            carOne.Year = 1941;
            carOne.EngineNoise = "purr";
            carOne.HonkNoise = "beep";
            carOne.IsDriveable = true;

            var carTwo = new Car()
            { 
                Make = "Mercury",
                Model = "Club Coupe",
                Year = 1940,
                EngineNoise = "rumble",
                HonkNoise = "honk honk",
                IsDriveable = true
            };

            var carThree = new Car(2021, "Toyota", "Camry", "vroom", "honk", false);
            
        
        
        
        
        
        
        
        
        }
            
            
    }
}
