using LINQTrainer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace LINQTrainer
{
    public class CarsXml
    {

        public void GenerateXmlFile(List<Car> queryResult)
        {

            var document = new XDocument();
            var carsElem = new XElement("Cars");

            // Syntax 3
            var elements = 
                from item in queryResult
                select new XElement("Car",
                          new XElement("Name", item.Name),
                          new XAttribute("Combined", item.Combined));

            carsElem.Add(elements);

            document.Add(carsElem);
            document.Save("fuel.xml");
            // Syntax 2
            /*/
            foreach (var item in queryResult.Take(10))
            {

                var car = new XElement("Car",
                          new XElement("Name", item.Name),
                          new XElement("Combined", item.Combined));

                carsElem.Add(car);
            /*/

            // Syntax 1               
            /*/
            var car = new XElement("Car");
            var name = new XElement("Name", item.Name);
            var combined = new XElement("Combined", item.Combined);

            carsElem.Add(name);
            carsElem.Add(combined);
            carsElem.Add(car);


        }

        document.Add(carsElem);
        document.Save("fuel.xml");

        /*/

        }

    }
}
