using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> dict = new Dictionary<string, List<decimal>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                decimal grade = Convert.ToDecimal(input[1]);
                if (dict.ContainsKey(name))
                {
                    dict[name].Add(grade);
                }
                else
                {
                    dict.Add(name, new List<decimal>() {grade});
                }
            }
            foreach (var student in dict)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(' ', student.Value.Select(grade => grade.ToString("F2")))} (avg: {student.Value.Average():f2})"); ;
            }
        }

        
    }
}
