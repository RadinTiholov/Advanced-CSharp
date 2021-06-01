using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _1._Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lines = new List<string>();
            using (StreamReader sr = new StreamReader("text.txt"))
            {
                while (!sr.EndOfStream)
                {
                    lines.Add(sr.ReadLine());
                }
            }
            for (int i = 0; i < lines.Count; i++)
            {
                if (i % 2 == 0)
                {
                    StringBuilder str = new StringBuilder(lines[i]);
                    for (int j = 0; j < lines[i].Length; j++)
                    {
                        if (str[j] == '-' || str[j] == ',' || str[j] == '.' || str[j] == '?' || str[j] == '!')
                        {
                            str[j] = '@';
                        }
                    }
                    //
                    string[] help = str.ToString().Split();
                    Array.Reverse(help);
                    
                    Console.WriteLine(string.Join(" ", help));
                }
            }
        }
    }
}
