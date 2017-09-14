﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndPolymorphisms
{
    class Automobile : Vehicle
    {
        private int numberOfWheels;
        private float wheelSize;
        private int numberOfDoors;

        public int NumberOfWheels
        {
            get { return this.numberOfWheels; }
        }

        public Automobile(int numberOfWheels, float wheelSize, int numberOfDoors, int seats, int carryingCapacity, string color, double movementSpeed)
        {
            this.numberOfWheels = numberOfWheels;
            this.wheelSize = wheelSize;
            this.numberOfDoors = numberOfDoors;
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;
            
        }

        //We don't need to override Move() in this class because there are no changes we need to make.
    }
}
