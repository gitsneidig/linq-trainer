using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LINQTrainer
{
    class WithLinq
    {

        public static void ShowLargeFilesWithLinq(string path)
        {
            var query = new DirectoryInfo(path).GetFiles()
                        .OrderByDescending(f => f.Length)
                        .Take(5);

            //orderby file.Length descending
            //select file;
            foreach (var file in query.Take(5))
            {
                Console.WriteLine($"{file.Name,-20} : {file.Length,10:N0}");
            }


        }

        public void ShowScottList()
        {

            IEnumerable<Employee> employees = new List<Employee>()
            {
                new Employee { firstName = "Scott", lastName = "Alen" },
                new Employee { firstName = "Bob", lastName = "Martin" }
            };

            IEnumerable<Employee> scottList = employees.Where(item => item.firstName == "Scott");

            foreach(var scott in scottList)
            {
                Console.WriteLine($"{scott.firstName} {scott.lastName} \n");
            }

        }



            
        

    }
}
