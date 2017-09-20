using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphisms
{
    interface IShape
    {
        string Name { get; set; } //do not include public
        //if you create a property in an interface, you need to create a field

        void GetInfo(); //interface methods cannot have a definition
        double Area();
    }
}
