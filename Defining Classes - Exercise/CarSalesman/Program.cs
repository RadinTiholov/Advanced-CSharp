using System;
using System.Collections.Generic;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Engine> enginesList = new List<Engine>();
            List<Car> carList = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Engine engine;
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input.Length == 2)
                {
                    engine = new Engine(input[0], int.Parse(input[1]));
                }
                else if (input.Length == 3)
                {
                    int number;

                    bool success = int.TryParse(input[2], out number);
                    if (success)
                    {
                        engine = new Engine(input[0], int.Parse(input[1]), number);
                    }
                    else
                    {
                        engine = new Engine(input[0], int.Parse(input[1]), input[2]);
                    }

                }
                else
                {
                    engine = new Engine(input[0], int.Parse(input[1]), int.Parse(input[2]), input[3]);
                }
                enginesList.Add(engine);
            }
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                Engine helpEngine = new Engine(" ", 0);
                Car car;
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (var engine in enginesList)
                {
                    if (input[1] == engine.Model)
                    {
                        helpEngine = engine;
                    }
                }
                if (input.Length == 2)
                {
                    car = new Car(input[0], helpEngine);
                }
                else if (input.Length == 3)
                {
                    int number;

                    bool success = int.TryParse(input[2], out number);
                    if (success)
                    {
                        car = new Car(input[0], helpEngine, number);
                    }
                    else
                    {
                        car = new Car(input[0], helpEngine, input[2]);
                    }

                }
                else
                {
                    car = new Car(input[0], helpEngine, int.Parse(input[2]), input[3]);
                }
                carList.Add(car);
            }
            foreach (var car in carList)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                string displaement = car.Engine.Displacement == 0 ? "n/a" : car.Engine.Displacement.ToString();
                Console.WriteLine($"    Displacement: {displaement}");
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                string weight = car.Weight == 0 ? "n/a" : car.Weight.ToString();
                Console.WriteLine($"  Weight: {weight}");
                Console.WriteLine($"  Color: {car.Color}");
            }
        }
    }
}
