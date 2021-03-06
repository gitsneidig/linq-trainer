using LINQTrainer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQTrainer
{
    public static class CustomFilterOperator
    {

        // This is a textbooks LINQ operator, it has 
        // an extension method for IEnumerable<T>, with this keyword
        // it returns an IEnumerable<T>
        // it has a Func parameter that expresses how the list processed
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> source, 
                                                Func<T, bool> predicate)
        {
            var result = new List<T>();

             foreach (var item in source)
            {
                if(predicate(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }


    }
}
