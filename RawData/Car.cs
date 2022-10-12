using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {
        public Car(string model ,Engine engine, Cargo cargo, Tires[] tires)
        {
            Model = model;
            EngineData = engine;
            CargoData = cargo;
            TiresData = tires;
            
        }
        
        public string Model { get; set; }
        public Engine EngineData { get; set; }
        public Cargo CargoData { get; set; }
        public Tires[] TiresData { get; set; }


    }
}
