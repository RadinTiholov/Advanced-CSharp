using System;
using System.Collections.Generic;
using System.Text;

namespace TupleProblem
{
    public class Tuple<T1,T2>
    {
        public Tuple(T1 first, T2 second)
        {
            item1 = first;
            item2 = second;
        }
        public T1 item1 { get; set; }
        public T2 item2 { get; set; }
    }
}
