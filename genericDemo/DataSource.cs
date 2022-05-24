using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericDemo
{
    internal class DataSource<T>
    {
        public T Data { get; set; }

        public static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }

    public class KeyValuePair<Tkey, TValue>
    {
        public Tkey Key { get; set; }
        public TValue Value { get; set; }

    }


}
