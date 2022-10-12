using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //Car car = new Car();
            //car.Make = "VW";
            //car.Model = "MK3";
            //car.Year = 2025;
            //car.FuelQuantity = 200;
            //car.FuelConsumption = 200;
            //Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");-1
            //car.Drive(2000);
            //Console.WriteLine(car.WhoAmI());-2
            //string make=Console.ReadLine();
            //string model =Console.ReadLine();
            //int year = int.Parse(Console.ReadLine());
            //double fuelQuantity=double.Parse(Console.ReadLine());
            //double fuelConsumption=double.Parse(Console.ReadLine());
            //Car firstCar =new Car();
            //Car secondCar =new Car(make,model,year);
            //Car thirdCar =new Car(make,model,year,fuelQuantity,fuelConsumption);-3
            //Tire[] tires = new Tire[4]
            //{
            //    new Tire(1, 2.5),
            //    new Tire(1, 2.1),
            //    new Tire (2,0.5),
            //    new Tire(2,2.3)
            //};
            //Engine engine = new Engine(560, 6300);
            //Car car = new Car("Lamborghini","Urus",2020,250,9,engine,tires);-4


            string tireInfo = Console.ReadLine();
            List<Tire[]> tiresCollection = new List<Tire[]>();
            List<double> tiresPressure = new List<double>();
            while (!tireInfo.Equals("No more tires"))
            {
                string[] arr = tireInfo.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Tire[] tires = new Tire[4];
                for (int i = 0, j = 0; i < 4; i++, j += 2)
                {
                    tires[i] = new Tire(int.Parse(arr[j]), double.Parse(arr[j + 1]));
                    tiresPressure.Add(double.Parse(arr[j+1]));
                }
                tiresCollection.Add(tires);

                tireInfo = Console.ReadLine();
            }
            string engineInfo = Console.ReadLine();
            List<Engine> enginesCollection = new List<Engine>();
            while (!engineInfo.Equals("Engines done"))
            {
                string[] arr = engineInfo.Split();
                int enginePower = int.Parse(arr[0]);
                double engineCapacity = double.Parse(arr[1]);
                enginesCollection.Add(new Engine(enginePower, engineCapacity));
                engineInfo = Console.ReadLine();
            }
            string carsSpecial = Console.ReadLine();
            List<Car> carCollection = new List<Car>();
            while (!carsSpecial.Equals("Show special"))
            {
                string[] arrInfo = carsSpecial.Split();
                string make = arrInfo[0];
                string model = arrInfo[1];
                int year = int.Parse(arrInfo[2]);
                double fuelQuantity = double.Parse(arrInfo[3]);
                double fuelConsumption = double.Parse(arrInfo[4]);
                int engineIndex = int.Parse(arrInfo[5]);
                int tiresIndex = int.Parse(arrInfo[6]);


                carCollection.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, enginesCollection[engineIndex], tiresCollection[tiresIndex]));

                carsSpecial = Console.ReadLine();
            }
            foreach (var car in carCollection)
            {
                
                
                if (car.Year >= 2017
                    && car.Engine.HorsePower > 300)

                {

                    car.Drive(0.2);
                    Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}\nHorsePowers: {car.Engine.HorsePower}\nFuelQuantity: {car.FuelQuantity}");



                }
            }




        }
    }
}
