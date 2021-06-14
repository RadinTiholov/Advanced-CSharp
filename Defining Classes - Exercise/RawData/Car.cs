using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {
        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType, double tire1Pressure,
            int tire1Age, double tire2Pressure,
            int tire2Age, double tire3Pressure,
            int tire3Age, double tire4Pressure,
            int tire4Age)
        {
            this.Model = model;
            this.Engine = new Engine() { EngineSpeed = engineSpeed, EnginePower = enginePower };
            this.Cargo = new Cargo() {CargoType = cargoType, CargoWeight  = cargoWeight };
            this.Tires = new Tire[4];
            Tires[0] = new Tire() { TirePressure = tire1Pressure, TireAge = tire1Age};
            Tires[1] = new Tire() { TirePressure = tire2Pressure, TireAge = tire2Age};
            Tires[2] = new Tire() { TirePressure = tire3Pressure, TireAge = tire3Age};
            Tires[3] = new Tire() { TirePressure = tire4Pressure, TireAge = tire4Age};
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] Tires { get; set; }

        public bool isSmallerThanOne() 
        {
            foreach (var tire in Tires)
            {
                if (tire.TirePressure < 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
