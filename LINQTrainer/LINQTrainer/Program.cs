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

            //var carsProcessor = new Cars();
            //var cars = carsProcessor.ProccessFile("C:/dev/github/new/linq-trainer/linq-trainer/LINQTrainer/LINQTrainer/CSV/fuel.csv");

            var cars = CarExtensions.ProccessFile("C:/dev/github/new/linq-trainer/linq-trainer/LINQTrainer/LINQTrainer/CSV/fuel.csv");
            var descQuery = cars.Where(c => c.Manufacturer == "BMW").OrderByDescending(c => c.Combined).ThenBy(c => c.Name).Select(c => c);





            foreach (var car in descQuery.Take(10))
            {
                Console.WriteLine($" {car.Name} : {car.Combined}");
            }

        }
    }
}
