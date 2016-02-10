using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MusicShopManager.Interfaces;

namespace Music_Shop_Management
{
    public class ElectricGuitar : Guitars, IElectricGuitar
    {
        public ElectricGuitar(string make, string model, decimal price, string color, string bodyWood, string fingerboardWood, int numberOfAdapters, int numberOfFrets)
            : base(make, model, price, color, bodyWood, fingerboardWood)
        {
            this.IsElectronic = true;
            this.NumberOfAdapters = numberOfAdapters;
            this.NumberOfFrets = numberOfFrets;
        }
        public int NumberOfAdapters { get; private set; }

        public int NumberOfFrets { get; private set; }

        public override string ToString()
        {
            var electricGuitar = new StringBuilder();
            electricGuitar
                .Append(base.ToString())
                .AppendFormat("Adapters: {0}", this.NumberOfAdapters).AppendLine()
                .AppendFormat("Frets: {0}", this.NumberOfFrets).AppendLine();
            return electricGuitar.ToString();
        }
    }
}
