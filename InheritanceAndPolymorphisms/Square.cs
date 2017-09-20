using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphisms
{
    class Square : Shape //Square will inherit from Shape
    {

        public double Length { get; set; }

        //child class inheriting the abstract class must implement the abstract member
        //we have to override the abstract method

        //constructor
        public Square(string name, double length) : base(name)  //need to reference the base class's constructor
            //if there was no default constructor, you would just delete base(name) and add Name = name; below
        {
            Length = length;
        }

        //need to override the method
        public override double Area()
        {
            return Length * Length;
        }

    }
}
