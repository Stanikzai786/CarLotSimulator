using CarLotSimulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Car
    {
        public Car()
        {
            CarLots.numberOfCars++;
        }
        public Car(string make, string model, int year, string honkNoise, string engineNoise, bool isDriveable )
        {
            Make = make;
            Model = model;
            Year = year;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;
            CarLots.numberOfCars++;

        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set;}
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string noise) 
        {
        Console.WriteLine($"The {Make}'s engine sounds like this: {noise}");
        }
        public void MakeHonkNoise()
        { 
        Console.WriteLine($"The {Make}'s Honk soudns like this {HonkNoise}");
        }
    }
}
