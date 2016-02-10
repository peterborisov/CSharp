using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using MusicShopManager.Interfaces;

namespace Music_Shop_Management
{
    public class Microphones : MusicShopManager.Models.Article, IMicrophone
    {
        private bool hasCable;
        private string color;

        public Microphones(string make, string model, decimal price,bool hasCable)
            : base( make, model, price)
        {
            this.HasCable = hasCable;          
        }
        public bool HasCable { get; set; }
        public override string ToString()
        {
            var microphone = new StringBuilder();
            microphone
                .Append(base.ToString())
                .AppendFormat("Cable: {0}", this.HasCable ? "yes" : "no")
                .AppendLine();
            return microphone.ToString();
        }
    }
}
