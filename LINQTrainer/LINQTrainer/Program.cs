using LINQTrainer.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;

namespace LINQTrainer
{
    class Program : Cars
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

            //var movieList = new MovieExamples();
            //foreach (var movie in movieList.MovieTester())
            //{
            //    Console.WriteLine($"{movie.Title}");
            //}

            var carsRepo = new Cars();
            List<Car> cars = carsRepo.ProccessFile("C:/dev/github/new/linq-trainer/linq-trainer/LINQTrainer/LINQTrainer/CSV/fuel.csv");
            foreach (var car in cars)
            {
                Console.WriteLine(car.Name);
            }

        }
    }
}
