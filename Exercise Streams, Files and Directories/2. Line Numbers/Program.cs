using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _2._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> lines = new List<string>();
            //using (StreamReader sr = new StreamReader("text.txt"))
            //{
            //    while (!sr.EndOfStream)
            //    {
            //        lines.Add(sr.ReadLine());
            //    }
            //}
            string[] lines = File.ReadAllLines("text.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                int letterCount = 0;
                int punctualSymbolCount = 0;
                foreach (char item in lines[i])
                {
                    if (Char.IsLetter(item))
                    {
                        letterCount++;
                    }
                    else if (Char.IsPunctuation(item))
                    {
                        punctualSymbolCount++;
                    }
                }
                lines[i] = $"Line {i} " + lines[i] + $" ({letterCount})({punctualSymbolCount})";
            }
            File.WriteAllLines("output.txt", lines);
        }
    }
}
