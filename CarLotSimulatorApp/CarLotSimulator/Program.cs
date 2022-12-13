using Classes;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            CarLots carLot = new CarLots();
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            Car car1 = new Car("BMW", "M4", 2022, "vroom vroom", "beep beep", true);
            carLot.ListOfCars.Add(car1);
            
            Console.WriteLine($"Number of cars: {CarLots.numberOfCars}");

            Car car2 = new Car();
            car2.Year = 2022;
            car2.Make = "Toyota";
            car2.Model = "Pruis";
            carLot.ListOfCars.Add(car2);
            
            Console.WriteLine($"Number of cars: {CarLots.numberOfCars}");


            List<int> list = new List<int> { 1, 2, 3 };
            Car car3 = new Car()
            {
                Year = 2024,
                Make = "Ford",
                Model = "Rapter",
                HonkNoise = "yak yak",
                IsDriveable = true
            };

            Console.WriteLine($"Number of cars: {CarLots.numberOfCars}");
            carLot.ListOfCars.Add(car3);
            foreach (var car in carLot.ListOfCars)
            {
                Console.WriteLine($" year:  {car.Year} Make {car.Make} Model {car.Model}");
                Console.WriteLine($"Number of cars in the lot is: {CarLots.numberOfCars}");
            }
        }
    }
    //*************BONUS*************//

    // Set the properties utilizing the 3 different ways we learned about, one way for each car

    //*************BONUS X 2*************//

    //Create a CarLot class


    //It should have at least one property: a List of cars
    //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
    //At the end iterate through the list printing each of car's Year, Make, and Model to the console
}
    

