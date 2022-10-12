using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engineData, int weight, string color) 
        {

            Model = model;
            EngineData = engineData;
            Color = color;
            Weight = weight;
        }
        public Car(string model, Engine engineData, int weight):this(model,engineData)
        {
            Weight = weight;
        }
        public Car(string model, Engine engineData, string color):this(model,engineData)
        {
            Color = color;
        }
        public Car(string model,Engine engineData)
        {
            Weight = 0;
            Color = "n/a";
        }
        public string Model { get; set; }
        public Engine EngineData { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }
        public override string ToString()
        {
            if (this.Weight==0&&this.Color=="n/a")
            {
                return $"{Model}:\n {EngineData.ToString()}\n Weight: n/a\nColor: n/a";
            }
            else if (this.Weight==0)
            {
                return $"{Model}:\n {EngineData.ToString()}\n Weight: n/a\nColor: {Color}";
            }
            else if (this.Color=="n/a")
            {
                return $"{Model}:\n {EngineData.ToString()}\n Weight: {Weight}\nColor: n/a";
            }
            else
            {
                return $"{Model}:\n {EngineData.ToString()}\n Weight: {Weight}\nColor: {Color}";
            }
        }
    }
}
