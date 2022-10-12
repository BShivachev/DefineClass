using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }
       
       
        public Car(string make,string model,int year,double fuelQuantity,double fuelConsumption,Engine engine,Tire[] tires)
        {
            Make = make;
            Model = model;
            Year = year;
            FuelQuantity=fuelQuantity;
            FuelConsumption=fuelConsumption;
            Engine=engine;
            Tires=tires;
           
        }
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tires;
        private double totalPressure;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }
        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }
        
        public void Drive(double distance)
        {
           
            double fuelLeft = fuelQuantity - distance * fuelConsumption;
            if (fuelLeft<0)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
                
            }
            else
            {
                fuelQuantity = fuelLeft;
            }
        }
       
        public string WhoAmI()
        {

            string result = $"Make: {this.Make}\nModel: { this.Model}\nYear: { this.Year}\nFuel: { this.FuelQuantity:F2}";
            return result;
        }





    }
}
