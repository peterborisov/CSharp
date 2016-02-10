using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MusicShopManager.Interfaces;
using MusicShopManager.Models;

namespace Music_Shop_Management
{
    public abstract class Instruments :Article, IInstrument
    {
        private string color;
        protected static bool isElectronic;

        public Instruments(string make, string model, decimal price, string color) 
            : base(make, model, price)
        {
            this.Color = color;         
        }   
        public string Color 
        { get { return this.color; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The <parameter> is required.");
                }
                this.color = value;
            }
        }
        public bool IsElectronic
        {
            get; set; }
        public override string ToString()
        {
            var instrument = new StringBuilder();
            instrument
                .Append(base.ToString())
                .AppendFormat("Color: {0}", this.Color)
                .AppendLine()
                .AppendFormat("Electronic: {0}", this.IsElectronic ? "yes" : "no")
                .AppendLine();
            return instrument.ToString();
        }
    }
}
