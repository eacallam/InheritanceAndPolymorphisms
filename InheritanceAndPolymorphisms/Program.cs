using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphisms
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat ssElizabeth = new Boat(3, 5, "Red", 80.0d, .90d);
            ssElizabeth.Move();
            ssElizabeth.Move();
            Console.WriteLine("Boat "+ ssElizabeth.GetDistanceTraveled()); //did not have to override to access this method; we used the same one from the parent class

            Automobile tesla = new Automobile(4, 4f, 4, 5, 10, "red", 80.0d);
            tesla.Move();
            Console.WriteLine("Automobile " + tesla.GetDistanceTraveled());

            Square square1 = new Square("square", 5);
            square1.GetInfo();
            Console.WriteLine(square1.Area());

            Circle circle1 = new Circle("circle", 10);
            circle1.GetInfo();
            Console.WriteLine(circle1.Area());
        }
    }
}
