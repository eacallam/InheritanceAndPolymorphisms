using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphisms
{
    class Vehicle
    {
        //FIELDS
        protected int seats;
        protected int carryingCapacity;
        protected string color;
        protected double movementSpeed;
        protected double distanceTraveled;

        private float gearRatio;
        private float engineSize;

        //PROPERTIES
        public int Seats
        {
            get { return this.seats; }
        }

        public int CarryingCapacity
        {
            get { return this.carryingCapacity; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public double DistanceTraveled
        {
            get { return this.distanceTraveled; }
        }

        //CONSTRUCTORS
        public Vehicle()
        {

        }

        public Vehicle(int seats, int carryingCapacity, string color, double movementSpeed)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;

            distanceTraveled = 0.0d;

        }

        //METHODS
        public virtual void Move() //virtual gives the derived classes the option to override this Method
        {
            distanceTraveled += movementSpeed; //don't need this because it knows to pull this because of scope
        }

        public virtual string GetDistanceTraveled()
        {
            return "Distance Traveled: " + distanceTraveled + "\n";
        }

        
    }
}
