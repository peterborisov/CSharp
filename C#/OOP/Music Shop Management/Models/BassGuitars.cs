using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MusicShopManager.Interfaces;

namespace Music_Shop_Management

{
    public class BassGuitar : Guitars, IBassGuitar
    {
        public BassGuitar(string make, string model, decimal price, string color, string bodyWood, string fingerboardWood)
            : base(make, model, price, color, bodyWood, fingerboardWood)
        {
            this.IsElectronic = true;
            this.NumberOfStrings = 4;
        }
    }
}

        
     