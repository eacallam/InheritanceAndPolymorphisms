using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphisms
{
    class Circle : IShape //need to implement all the methods
        //can hover over "IShape" and click "show potential fixes" to automatically implement interface
    {
        public string Name { get; set; }
        public double Radius { get; set; }
        public Circle(string name, double radius)
        {
            Name = name;
            Radius = radius;
        }

        public double Area()
            //Math has methods we have access to
        {
            double pi = Math.PI;
            return pi * Math.Pow(Radius, 2);
        }

        public void GetInfo()
        {
            Console.WriteLine("I am a " + Name);
        }
    }
}
