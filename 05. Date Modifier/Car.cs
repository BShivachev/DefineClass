using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public Car()
        {
            TravelledDistance = 0;
        }
        public Car(string model,double fuelAmount,double fuelCons) :this()
        {
                Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelCons;
            
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }
        public void CalculateDistance(int amountKilometers)
        {
            bool haveEnoughFuel = FuelAmount - FuelConsumptionPerKilometer * amountKilometers >= -0;
                
            if (haveEnoughFuel)
            {
                FuelAmount -= amountKilometers*FuelConsumptionPerKilometer;
                TravelledDistance += amountKilometers;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
