using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Estates.Interfaces;

namespace Problem_1___Estates
{
    public class House : Estate,IHouse
    {
        private int floors;

        public House() 
        
        {
            this.Type =EstateType.House;
        }
        public int Floors
        {
            get { return this.floors; }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("value must be from 0 to 10");
                }
                this.floors = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + ", Floors: " + this.Floors;
        }     
    }
}
