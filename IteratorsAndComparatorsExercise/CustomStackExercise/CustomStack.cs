using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CustomStackExercise
{
    public class CustomStack<T>: IEnumerable<T>
    {
        public CustomStack()
        {
            list = new List<T>();
        }
        private readonly List<T> list;
        public void Push(params T[] elements) 
        {
            for (int i = 0; i < elements.Length; i++)
            {
                list.Add(elements[i]);
            }
        }
        public T Pop() 
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("No elements");
            }
            else
            {
                T help = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                return help;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = list.Count-1; i >= 0; i--)
            {
                yield return list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    }
}
