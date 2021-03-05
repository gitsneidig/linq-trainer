using System;
using System.Collections.Generic;
using System.Text;

namespace LINQTrainer
{
    public static class MyLinq
    {
        public static int ECount<T>(this IEnumerable<T> sequence)
        {
            int count = 0;
            foreach (var item in sequence)
            {
                count += 1;
            }
            return count;
        }
    }
}
