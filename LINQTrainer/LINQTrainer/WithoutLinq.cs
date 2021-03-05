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

        public List<Employee> employees = new List<Employee>();

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


        public void ShowScottListLegacy()
        {

            IEnumerable<Employee> employees = new List<Employee>()
            {
                new Employee { firstName = "Scott", lastName = "Alen" },
                new Employee { firstName = "Bob", lastName = "Martin" }
            };

            Console.WriteLine(employees.Count());

            /*/
            // EnumerableExtensions is in namespace Microsoft.Practices.ObjectBuildedr2
            // and no longer support/retired
            // The closes thing to LINQ that existed in C# 2.0
            IEnumerable<Employee> scottList =
                EnumerableExtensions.Where(employees,
                    delegate (Employee scott)
                    {
                        Console.WriteLine($"{scott.firstName} {scott.lastName} \n");
                    });
            /*/
        }

        public void IEnumeratorExample()
        {

            employees.Add(new Employee { id = 1, firstName = "Scott", lastName = "Alen" });
            employees.Add(new Employee { id = 2, firstName = "Bob", lastName = "Martin" });

            IEnumerator<Employee> enumerator = employees.GetEnumerator();

            while(enumerator.MoveNext())
            {
                Console.WriteLine($"{enumerator.Current.firstName} {enumerator.Current.lastName}");
            }



        }


    }
}
