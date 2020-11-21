using System;

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
            var lot = new CarLots();


            //Now that the Car class is created we can instanciate 3 new cars

            //------------1-----------
            var prizeCar = new Car();
            prizeCar.Year = 2020;
            prizeCar.Make = "Jaguar";
            prizeCar.Model = "XJ220";
            prizeCar.EngineNoise = "Deep";
            prizeCar.HonkNoise = "Beep";
            prizeCar.IsDriveable = true;

            lot.Cars.Add(prizeCar);


            //------------2-----------
            var prizeCar2 = new Car()
            {
                Year = 2020,
                Make = "Ford",
                Model = "Mustang",
                EngineNoise = "Rumble",
                HonkNoise = "Honk",
                IsDriveable = true,
            };

            lot.Cars.Add(prizeCar2);

            //-----------3------------

            var prizeCar3 = new Car(2020, "Honda", "Accord", "Vroom", "Honky", true);

            lot.Cars.Add(prizeCar3);

            Console.WriteLine($"Number of cars in lot: {CarLots._numberOfCars}");
            //Set the properties for each of the cars


            //Call each of the methods for each car

            prizeCar.MakeEngineNoise(prizeCar.EngineNoise);
            prizeCar2.MakeEngineNoise(prizeCar2.EngineNoise);
            prizeCar3.MakeEngineNoise(prizeCar3.EngineNoise);


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
        }
    }
}
