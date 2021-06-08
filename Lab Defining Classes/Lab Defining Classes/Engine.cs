using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Engine
    {
        public Engine(int horsePower, double cubicCapacity)
        {
            this.CubicCapacity = cubicCapacity;
            this.HorsePower = horsePower;
        }
        private int horsePower;
        private double cubicCapacity;

        public int HorsePower 
        {
            get { return horsePower; }
            set { horsePower = value; }
        }
        public double CubicCapacity
        {
            get { return cubicCapacity; }
            set { cubicCapacity = value; }
        }

    }
}
