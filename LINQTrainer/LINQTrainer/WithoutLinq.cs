using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using static LINQTrainer.Program;
using System.Diagnostics.CodeAnalysis;

namespace LINQTrainer
{
    public class WithoutLinq
    {

        public static void ShowLargeFilesWithoutLinq(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles();
            Array.Sort(files, new FileInfoComparer());

            for (int i = 0; i < 5; i++)
            //foreach(FileInfo file in files)
            {
                Console.WriteLine($"{files[i].Name,-20}: {files[i].Length,10:N0}");
            }
        }

        public class FileInfoComparer : IComparer<FileInfo>
        {
            public int Compare([AllowNull] FileInfo x, [AllowNull] FileInfo y)
            {
                return y.Length.CompareTo(x.Length);
            }
        }

    }
}
