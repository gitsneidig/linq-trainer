using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using LINQTrainer.Models;

namespace LINQTrainer
{
    public static  class CarExtensions
    {

        public static IEnumerable<Car> ProccessFile(string path)
        {
            return File.ReadAllLines(path).Skip(1)
                    .Where(line => line.Length > 1)
                    .ToCar();
        }


        public static IEnumerable<Car> ToCar(this IEnumerable<string> source)
        {
            foreach (var line in source)
            {
                var columns = line.Split(',');

                yield return new Car
                {
                    Year = int.Parse(columns[0]),
                    Manufacturer = columns[1],
                    Name = columns[2],
                    Displacement = double.Parse(columns[3]),
                    Cylinders = int.Parse(columns[4]),
                    City = int.Parse(columns[5]),
                    Highway = int.Parse(columns[6]),
                    Combined = int.Parse(columns[7])
                };
            }
        }


    }
}
