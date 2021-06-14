using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        public Engine(string model, int power)
        {
            Model = model;
            Power = power;
            Efficiency = "n/a";
            Displacement = 0;
        }
        public Engine(string model, int power, string efficiency)
        {
            Model = model;
            Power = power;
            Efficiency = efficiency;
            Displacement = 0;
        }
        public Engine(string model, int power, int displacement,string efficiency)
        {
            Model = model;
            Power = power;
            Efficiency = efficiency;
            Displacement = displacement;
        }
        public Engine(string model, int power, int displacement)
        {
            Model = model;
            Power = power;
            Efficiency = "n/a";
            Displacement = displacement;
        }
        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }
    }
}
