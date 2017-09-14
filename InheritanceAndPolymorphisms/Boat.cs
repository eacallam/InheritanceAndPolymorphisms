using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphisms
{
    class Boat : Vehicle
    {
        private double waterDrag; //not creating a property because don't need to access this once set

        public Boat(int seats, int carryingCapacity, string color, double movementSpeed, double waterDrag)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
            this.waterDrag = waterDrag;
        }

        //need to override parent class method because boat moves differently

        public override void Move()
        {
            distanceTraveled += movementSpeed * waterDrag;

        }

        //if wanted to keep the same, use base.Move() in the Program body, as long as it's accessible based on permissions
    }
}
