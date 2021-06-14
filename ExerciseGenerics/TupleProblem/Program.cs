using System;
using System.Collections.Generic;
using System.Text;

namespace TupleProblem
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] nameAndAdress = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string help = $"{nameAndAdress[0]} {nameAndAdress[1]}";
            StringBuilder secondHelp = new StringBuilder();
            for (int i = 3; i < nameAndAdress.Length; i++)
            {
                secondHelp.Append(nameAndAdress[i] + " ");
            }
            Threeuple<string, string, string> firstTuple = new Threeuple<string, string, string>(help, nameAndAdress[2], secondHelp.ToString());
            Console.WriteLine($"{firstTuple.item1} -> {firstTuple.item2} -> {firstTuple.item3}");
            //
            string[] nameAndBeer = Console.ReadLine().Split(); 
            Threeuple<string, int, bool> secondtuple = new Threeuple<string, int, bool>(nameAndBeer[0], int.Parse(nameAndBeer[1]), nameAndBeer[2] == "drunk"?true:false);
            Console.WriteLine($"{secondtuple.item1} -> {secondtuple.item2} -> {secondtuple.item3}");
            //
            string[] someNumbers = Console.ReadLine().Split();
            Threeuple<string, double, string> thirdTuple = new Threeuple<string, double, string>(someNumbers[0], double.Parse(someNumbers[1]), someNumbers[2]);
            Console.WriteLine($"{thirdTuple.item1} -> {thirdTuple.item2} -> {thirdTuple.item3}");


        }
    }
}
