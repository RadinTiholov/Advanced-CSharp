using System;
using System.Linq;

namespace IteratorsAndComparatorsExercise
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            ListyIterator<string> list = null;
            while (input != "END")
            {
                var splitted = input.Split().ToArray();
                if (splitted[0] == "Create")
                {
                    list = new ListyIterator<string>(splitted.Skip(1).ToArray());
                }
                else if (splitted[0] == "Move")
                {
                    Console.WriteLine(list.Move());
                }
                else if (splitted[0] == "HasNext")
                {
                    Console.WriteLine(list.HasNext());
                }
                else if (splitted[0] == "Print")
                {
                    list.Print();
                }
                else if (splitted[0] == "PrintAll")
                {
                    foreach (var item in list)
                    {
                        Console.Write(item + " ");
                        
                    }
                    Console.WriteLine();
                }
                input = Console.ReadLine();
            }

        }
    }
}
