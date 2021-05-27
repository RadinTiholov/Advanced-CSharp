using System;
using System.Collections.Generic;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var hasSet = new HashSet<string>();
            while (input != "END")
            {
                var splitted = input.Split(", ");
                if (splitted[0] == "IN")
                {
                    hasSet.Add(splitted[1]);
                }
                else
                {
                    hasSet.Remove(splitted[1]);
                }
                input = Console.ReadLine();
            }
            if (hasSet.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var item in hasSet)
                {
                    Console.WriteLine(item);
                }
            }

        }
    }
}
