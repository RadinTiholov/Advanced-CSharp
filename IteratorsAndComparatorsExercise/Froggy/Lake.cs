using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Froggy
{
    public class Lake: IEnumerable<int>
    {
        public Lake(params int[] input)
        {
            numbers = new List<int>(input);
        }
        public readonly List<int> numbers;

        public IEnumerator<int> GetEnumerator()
        {
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    evens.Add(numbers[i]);
                }
                else
                {
                    odds.Add(numbers[i]);
                }
            }
            odds.Reverse();
            foreach (var item in odds)
            {
                evens.Add(item);
            }
            foreach (var item in evens)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    }
}
