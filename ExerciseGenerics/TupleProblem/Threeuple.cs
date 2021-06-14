using System;
using System.Collections.Generic;
using System.Text;

namespace TupleProblem
{
    public class Threeuple<T1,T2,T3>
    {
        public Threeuple(T1 first, T2 second, T3 three)
        {
            item1 = first;
            item2 = second;
            item3 = three;
        }
        public T1 item1 { get; set; }
        public T2 item2 { get; set; }
        public T3 item3 { get; set; }
    }
}
