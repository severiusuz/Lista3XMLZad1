using System;
using System.Xml.Serialization;
using Zad1.Models;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person { Name = "Hubi", LastName = "Sztan" };
            XmlSerializer x = new XmlSerializer(person.GetType());
            x.Serialize(Console.Out, person);
            Console.ReadKey();
        }
    }
}
