using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Estates.Interfaces;

namespace Problem_1___Estates
{
    public abstract class BuildingEstate : Estate,IBuildingEstate
    {
        private int rooms;
        private bool hasElevator;

    
        public bool Elevator { get; set; }
        public int NumberOfRooms { get; set; }
        public int Rooms
        {
            get { return this.rooms; }
            set
            {
                if (value < 0 || value > 20)
                {
                    throw new ArgumentException("Value must be from 0 to 20");
                }
                this.rooms = value;
            }
        }
        public bool HasElevator
        {
            get { return this.hasElevator; }
            set { this.hasElevator = value; }
        }
        public override string ToString()
        {
            return base.ToString() +
                String.Format(", Rooms: {0}, Elevator: {1}",
                this.Rooms, this.hasElevator ? "Yes" : "No");
        }
    }
}
