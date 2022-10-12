using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
               string model=carInfo[0];
                int engineSpeed=int.Parse(carInfo[1]);
                int enginePower =int.Parse(carInfo[2]);
                int cargoWeight=int.Parse(carInfo[3]);
                string cargoType =carInfo[4];
                double oneTirePress=double.Parse(carInfo[5]);
                int oneTireYear=int.Parse(carInfo[6]);
                double twoTirePress = double.Parse(carInfo[7]);
                int twoTireYear=int.Parse(carInfo[8]);
                double threeTirePress = double.Parse(carInfo[9]);
                int threeTireYear = int.Parse(carInfo[10]);
                double fourTirePress = double.Parse(carInfo[11]);
                int fourTireYear = int.Parse(carInfo[12]);
                Engine engine = new Engine();
                
                engine.Speed = engineSpeed;
                engine.Power = enginePower;
                Cargo cargo = new Cargo()
                { Weight = cargoWeight, Type = cargoType };
                

                Tires[] tires = new Tires[4];
                
                    tires[0] = new Tires(oneTirePress, oneTireYear);
                    tires[1] = new Tires(twoTirePress, twoTireYear);
                    tires[2] = new Tires(threeTirePress, threeTireYear);
                    tires[3] = new Tires(fourTirePress, fourTireYear);

               


                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }
                
            
            string command = Console.ReadLine();
            List<Car> resultCars = new List<Car>();
            if (command== "fragile")
            {
                resultCars=cars.Where(x=>x.CargoData.Type==command&&x.TiresData.Any(x=>x.Pressure<1.0)).ToList();
                
            }
            else
            {
                resultCars = cars.Where(x => x.CargoData.Type == command &&x.EngineData.Power>250 ).ToList();
            }
            foreach (var car in resultCars)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
