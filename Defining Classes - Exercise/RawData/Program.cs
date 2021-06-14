using System;
using System.Collections.Generic;

namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> list = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                Car car = new Car(tokens[0], int.Parse(tokens[1]), int.Parse(tokens[2]), int.Parse(tokens[3]), tokens[4],
                    double.Parse(tokens[5]), int.Parse(tokens[6]),
                    double.Parse(tokens[7]), int.Parse(tokens[8]),
                    double.Parse(tokens[9]), int.Parse(tokens[10]),
                    double.Parse(tokens[11]), int.Parse(tokens[12]));
                list.Add(car);
            }
            string line = Console.ReadLine();
            if (line == "fragile")
            {
                foreach (var car in list)
                {
                    if (car.Cargo.CargoType == "fragile" && car.isSmallerThanOne())
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else
            {
                foreach (var car in list)
                {
                    if (car.Cargo.CargoType == "flamable" && car.Engine.EnginePower > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }

        }
    }
}
