using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Estates.Interfaces;

namespace Problem_1___Estates
{
    public class SaleOffer:Offer,ISaleOffer
    {
        public SaleOffer()
        {
            this.Type = OfferType.Sale;
        }
        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }
    }
}
