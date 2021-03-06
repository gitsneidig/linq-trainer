using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;

namespace LINQTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = @"C:\windows";
            //var WithOutLinq = new WithoutLinq();
            //WithoutLinq.ShowLargeFilesWithoutLinq(path);
            //WithOutLinq.IEnumeratorExample();
            //WithOutLinq.ShowScottListLegacy();

            //var WithLinq = new WithLinq();
            //WithLinq.ShowLargeFilesWithLinq(path);
            // WithLinq.ShowScottList();

            var movieList = new CustomFilterOperator();
            foreach (var movie in movieList.MovieTester())
            {
                Console.WriteLine($"{movie.Title}");
            }
            



        }

    }
}
