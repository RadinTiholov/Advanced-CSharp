using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _3._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            string[] words = File.ReadAllLines("words.txt");
            string[] textWords = File.ReadAllText("text.txt").ToLower().Split(new char[]{' ', ',', '.', '!', '?', '-' });
            foreach (var word in words)
            {
                for (int i = 0; i < textWords.Length; i++)
                {
                    if (word == textWords[i])
                    {
                        if (dict.ContainsKey(word))
                        {
                            dict[word]++;
                        }
                        else
                        {
                            dict.Add(word, 1);
                        }
                    }
                }
            }
            string[] result = new string[dict.Count];
            string[] expectedResult = new string[dict.Count];
            int count = 0;
            foreach (var item in dict)
            {
                result[count] = $"{item.Key} {item.Value}";
                count++;
            }
            var sorted = dict.OrderByDescending(x => x.Value);
            int j = 0;
            foreach (var item in sorted)
            {
                expectedResult[j] = $"{item.Key} {item.Value}";
                j++;
            }
            File.WriteAllLines("actualResult.txt", result);
            File.WriteAllLines("expectedResult.txt", expectedResult);
            
        }
    }
}
