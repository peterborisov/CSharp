using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MusicShopManager.Interfaces;

namespace Music_Shop_Management
{
    public class Drums : Instruments,IDrums
    {
        private int width;
        private int height;

        public Drums(string make, string model, decimal price, string color, 
         int width,int heigth)
            : base(make, model, price,color)
        {
            this.Width = width;
            this.Height = heigth;
            this.IsElectronic = false;
        }
        public int Width { get; set; }
        public int Height { get; set; }
        public override string ToString()
        {
            var drums = new StringBuilder();
            drums
                .Append(base.ToString())
                .AppendFormat("Size: {0}cm x {1}cm", this.Width, this.Height)
                .AppendLine();
            return drums.ToString();
        }
    }
}
