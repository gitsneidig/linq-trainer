﻿using LINQTrainer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQTrainer
{
    class CustomFilterOperator
    {

        public IEnumerable<Movies> MovieTester()
        {

            var movies = new List<Movies>()
            {
                new Movies { Title = "The Dark Knight", Rating = 8.1f, Year = 2015 },
                new Movies { Title = "The King's Speech", Rating = 8.2f, Year = 2016 },
                new Movies { Title = "Casblanca", Rating = 8.3f, Year = 2017 },
                new Movies { Title = "Star Wars V", Rating = 8.4f, Year = 2018 }
            };

            var query = movies.Where(m => m.Year > 2016);

            return query;

            /*/
            foreach (var movie in query)
            {
                Console.Write(movie);
            }/*/
        }
    }
}
