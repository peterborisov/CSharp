using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MusicShopManager.Interfaces;
using MusicShopManager.Models;
using Music_Shop_Management;

namespace MusicShop.Models
{
    public class AcousticGuitar : Guitars, IAcousticGuitar
    {
        public AcousticGuitar
            (string make, string model, decimal price, string color, string bodyWood, string fingerboardWood, bool caseIncluded, StringMaterial material)
            : base(make, model, price, color, bodyWood, fingerboardWood)
        {
            this.IsElectronic = false;
            this.CaseIncluded = caseIncluded;
            this.StringMaterial = material;
        }
        public bool CaseIncluded { get; private set; }

        public StringMaterial StringMaterial { get; private set; }

        public override string ToString()
        {
            var acousticGuitar = new StringBuilder();
            acousticGuitar
                .Append(base.ToString())
                .AppendFormat("Case included: {0}", this.CaseIncluded ? "yes" : "no")
                .AppendLine()
                .AppendFormat("String material: {0}", this.StringMaterial.ToString())
                .AppendLine();
            return acousticGuitar.ToString();
        }

    }
}
