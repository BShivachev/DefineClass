using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
       
        public Engine(string model,int power)
        {
            Model = model;
            Power = power;
            Displacement = 0;
            Efficiency = "n/a";
        }
        public Engine(string model,int power,int displacement):this(model,power)
        {
            Displacement = displacement;
        }
        public Engine(string model, int power, string efficiency) : this(model, power)
        {
            Efficiency = efficiency;
        }
        public Engine(string model, int power, int displacement, string efficiency):this(model,power)
        {
            Displacement = displacement;
            Efficiency = efficiency;
        }
        
        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }

        public override string ToString()
        {
            if (this.Displacement == 0&&this.Efficiency=="n/a")
            {
                return $" {Model}:\n   Power: {Power}\n   Displacement: n/a\nEfficiency: n/a";
            }
            else if (this.Displacement == 0)
            {
                return $" {Model}:\n   Power: {Power}\n   Displacement: n/a\nEfficiency: {Efficiency}";
            }
            else if (this.Efficiency=="n/a")
            {
                return $" {Model}:\n   Power: {Power}\n   Displacement: {Displacement}\nEfficiency: n/a";
            }
            else
            {
                return $" {Model}:\n   Power: {Power}\n   Displacement: {Displacement}\nEfficiency: {Efficiency}";
            }
        }

    }
}
