using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphisms
{
    abstract class Shape //we can't create an instance of Shape
    {
        //don't need to create a field because VS will create one in the background
        //(this is a shorthand way to create the field in the background)

        public string Name { get; set; }

        //method
        abstract public double Area(); //we don't want to have a body for the method because it is abstract

        //method
        public void GetInfo()
        {
            Console.WriteLine("I am  a {0}", Name);
        }

        //constructor
        public Shape(string name)
        {
            Name = name;
        }

    }
}
