using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        public Car(string model, Engine engine)
        {
            Model = model;
            this.Engine = engine;
            Weight = 0;
            Color = "n/a";
        }
        public Car(string model, Engine engine, int weight)
        {
            Model = model;
            this.Engine = engine;
            Weight = weight;
            Color = "n/a";
        }
        public Car(string model, Engine engine, int weight, string color)
        {
            Model = model;
            this.Engine = engine;
            Weight = weight;
            Color = color;
        }
        public Car(string model, Engine engine, string color)
        {
            Model = model;
            this.Engine = engine;
            Weight = 0;
            Color = color;
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Color { get; set; }
    }
}
