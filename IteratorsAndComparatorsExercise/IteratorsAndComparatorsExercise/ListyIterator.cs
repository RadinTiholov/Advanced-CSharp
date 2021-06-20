using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparatorsExercise
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        public ListyIterator(params T[] collection)
        {
            list = new List<T>(collection);
            index = 0;
        }
        private readonly List<T> list;
        private int index;
        public bool Move() 
        {
            if (list.Count-1 > index)
            {
                index++;
                return true;
            }
            return false;
        }
        public bool HasNext()
        {
            if (list.Count-1 > index)
            {
                return true;
            }
            return false;
        }
        public void Print() 
        {
            if (list.Count <= 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            else
            {
                Console.WriteLine(list[index]);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in list)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    }
}
