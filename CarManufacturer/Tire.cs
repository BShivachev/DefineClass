using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarManufacturer
{
    public class Tire
    {
        public Tire(int year,double pressure)
        {
            Year = year;
            Pressure = pressure;
        }
        private int year;
        private double pressure;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double Pressure
        {
            get { return pressure; }
            set { pressure = value; }
        }
        public double GetTotalPressure(List<Tire[]> tires, int tireIndex)
        {
            double totalPressure = tires[tireIndex].Sum(x => x.Pressure);
            return totalPressure;

        }
    }
}
