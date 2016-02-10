using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Estates.Interfaces;

namespace Problem_1___Estates
{
    public class RentOffer:Offer,IRentOffer
    {      
        public RentOffer()
        {
            this.Type = OfferType.Rent;
        }

        public decimal PricePerMonth
        {
            get { return this.price; }
            set { this.price = value; }
        }
    }
}
