using System;
using System.Collections.Generic;

namespace SpeedRacing
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars=int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo=Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                string model=carInfo[0];
                double fuelAmount=double.Parse(carInfo[1]);
                double fuelConsump=double.Parse(carInfo[2]);
                Car car = new Car(model,fuelAmount,fuelConsump);
                cars.Add(car);
            }
            string command=Console.ReadLine();
            while (command!="End")
            {
                string[] arrCommand=command.Split(' ',StringSplitOptions.RemoveEmptyEntries);
                string currentModel=arrCommand[1];
                int amountKm=int.Parse(arrCommand[2]);

                cars.Find(x => x.Model.Equals(currentModel)).CalculateDistance(amountKm);
                command = Console.ReadLine();
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance} ");
            }
        }
    }
}
