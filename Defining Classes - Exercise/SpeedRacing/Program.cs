using System;
using System.Collections.Generic;

namespace SpeedRacing
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
                list.Add(new Car(tokens[0], double.Parse(tokens[1]), double.Parse(tokens[2])));
            }
            string input = Console.ReadLine();
            while (input != "End")
            {
                var splitted = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string carModel = splitted[1];
                double amountOfKm = double.Parse(splitted[2]);
                foreach (var car in list)
                {
                    if (car.Model == carModel)
                    {
                        car.Travel(amountOfKm);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var car in list)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmmount:F2} {car.TravelledDistance} ");
            }
        }
    }
}
