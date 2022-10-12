using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            int engineCount = int.Parse(Console.ReadLine());
            List<Engine> engineList = new List<Engine>();
            for (int i = 0; i < engineCount; i++)
            {
                string[] engineData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string engineModel = engineData[0];
                int enginePower = int.Parse(engineData[1]);
                Engine currentEngine;
                if (engineData.Length == 2)
                {
                    currentEngine = new Engine(engineModel, enginePower);
                }
                else if (engineData.Length == 3)
                {
                    if (IsDigit(engineData[2]))
                    {
                        currentEngine = new Engine(engineModel, enginePower, int.Parse(engineData[2]));
                    }
                    else
                    {
                        currentEngine = new Engine(engineModel, enginePower, engineData[2]);
                    }
                }
                else
                {
                    currentEngine = new Engine(engineModel, enginePower, int.Parse(engineData[2]), engineData[3]);
                }
                engineList.Add(currentEngine);
            }
            int countOfCars=int.Parse(Console.ReadLine());
            List<Car> carList = new List<Car>();
            for (int i = 0;i < countOfCars; i++)
            {
                string[] carData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string carModel = carData[0];
                string carEngine=carData[1];
                Car currentCar;
                Engine properEngine = engineList.Find(x => x.Model == carEngine);
                if (carData.Length == 2)
                {
                    currentCar = new Car(carModel, properEngine);
                }
                else if (carData.Length == 3)
                {
                    if (IsDigit(carData[2]))
                    {
                        currentCar = new Car(carModel, properEngine, int.Parse(carData[2]));
                    }
                    else
                    {
                        currentCar = new Car(carModel, properEngine, carData[2]);
                    }                    
                }
                else
                {
                    currentCar=new Car(carModel,properEngine, int.Parse(carData[2]), carData[3]);
                }
                carList.Add(currentCar);
            }
            foreach (var car in carList)
            {
                Console.WriteLine(car.ToString());
            }

        }
        static bool IsDigit(string x)
        {
            x.ToCharArray();
            if (char.IsDigit(x[0]))
            {
                return true;
            }
            return false;
        }

    }
}
