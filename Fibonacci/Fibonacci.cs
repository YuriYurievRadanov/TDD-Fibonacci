using System;
using System.Collections.Generic;

namespace Fibonacci
{
    public class Fibonacci
    {
        static void Main(string[] args)
        {

        }

        //public int GetNumber(int index)
        //{
        //    return 0;
        //}

        //public int GetNumber(int index)
        //{
        //    return index;
        //}

        //public int GetNumber(int index)
        //{
        //    if (index < 2)
        //        return index;
        //    return index - 1;
        //}

        public int GetNumber(int index)
        {
            if (index < 2) return index;
            return GetNumber(index - 1) + GetNumber(index - 2);
        }
    }
}
