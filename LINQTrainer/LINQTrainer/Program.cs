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
            string path = @"C:\windows";
            var WithOutLink = new WithoutLinq();
            //WithoutLinq.ShowLargeFilesWithoutLinq(path);
            WithOutLink.IEnumeratorExample();

            var WithLinq = new WithLinq();
            //WithLinq.ShowLargeFilesWithLinq(path);
            // WithLinq.ShowScottList();


        }

    }
}
