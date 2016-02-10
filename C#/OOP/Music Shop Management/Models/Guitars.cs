using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MusicShopManager.Interfaces;

namespace Music_Shop_Management
{
    public abstract class Guitars : Instruments, IGuitar
    {
        private string fingerboardWood;
        private string bodyWood;
        private int numberOfStrings=6;
        private string color;

        protected Guitars(string make, string model, decimal price, string color,
            string bodyWood, string fingerboardWood)
            : base(make, model, price, color)
        {
            this.NumberOfStrings = 6;
            this.BodyWood = bodyWood;
            this.FingerboardWood = fingerboardWood;
           
        }
     

        public string BodyWood
        {
            get; set; }

        public string FingerboardWood {
            get;
            set;
        }
        public int NumberOfStrings
        {
            get; set; }
        public override string ToString()
        {
            var guitar = new StringBuilder();
            guitar
                .Append(base.ToString())
                .AppendFormat("Strings: {0}", this.NumberOfStrings)
                .AppendLine()
                .AppendFormat("Body wood: {0}", this.BodyWood)
                .AppendLine()
                .AppendFormat("Fingerboard wood: {0}", this.FingerboardWood)
                .AppendLine();
            return guitar.ToString();
        }
    }
}
