using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Estates.Interfaces;

namespace Problem_1___Estates
{
    public class Garage : Estate,IGarage
    {
        private int height;
        private int width;

        public Garage()

        {
            this.Type = EstateType.Garage;
        }
        public int Height
        {
            get { return this.height; }
            set
            {
                if (value < 0 || value > 500)
                {
                    throw new ArgumentException("Value must be from 0 to 500");
                }
                this.height = value;
            }
        }

        public int Width
        {
            get { return this.width; }
            set
            {
                if (value < 0 || value > 500)
                {
                    throw new ArgumentException("Value must be from 0 to 500");
                }
                this.width = value;
            }
        }

        public override string ToString()
        {
            return base.ToString()+", Width: " + this.width + ", Height: " + this.Height;
        }
    }
}
