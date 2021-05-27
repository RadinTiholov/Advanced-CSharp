using System;
using System.Collections.Generic;

namespace _7._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var partyPeople = new HashSet<string>();
            while (input != "PARTY")
            {
                partyPeople.Add(input);
                input = Console.ReadLine();
            }
            var second = Console.ReadLine();
            while (second != "END")
            {
                partyPeople.Remove(second);
                second = Console.ReadLine();
            }
            Console.WriteLine(partyPeople.Count);
            foreach (var item in partyPeople)
            {
                char[] ch = item.ToCharArray();
                if (char.IsDigit(ch[0]))
                {
                    Console.WriteLine(item);
                }
            }
            foreach (var item in partyPeople)
            {
                char[] ch = item.ToCharArray();
                if (char.IsLetter(ch[0]))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
