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

            foreach (var item in queryResult.Take(10))
            {
                var car = new XElement("Car");
                var name = new XElement("Name", item.Name);
                var combined = new XAttribute("Combined", item.Combined);

                car.Add(name);
                car.Add(combined);
                carsElem.Add(car);

            }

            document.Add(carsElem);
            document.Save("fuel.xml");

        }

    }
}
