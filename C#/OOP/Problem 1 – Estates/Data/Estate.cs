using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Estates.Interfaces;

namespace Problem_1___Estates
{
    public class Estate : IEstate
    {
        private double area;
        private bool isFurnished;
        private string location;
        private EstateType type;
        private string name;
        private object price;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public EstateType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public double Area
        {
            get { return this.area; }
            set
            {
                if (value < 0 || value > 10000)
                {
                    throw new ArgumentException("invalid value");
                }
                this.area = value;
            }
        }
        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }
        public bool IsFurnished
        {
            get { return this.isFurnished; }
            set { this.isFurnished = value; }
        }

        public object Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public override string ToString()
        {
            return String.Format(
                "{0}: Name = {1}, Area = {2}, Location = {3}, Furnitured = {4}",
                this.Type, this.Name, this.Area,
                this.Location, this.isFurnished ? "Yes" : "No");
        }
    }
}
