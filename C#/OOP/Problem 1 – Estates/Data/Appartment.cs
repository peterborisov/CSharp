using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Estates.Interfaces;

namespace Problem_1___Estates
{
    public class Appartment : BuildingEstate,IApartment
    {
        public Appartment()
        {
            this.Type = EstateType.Apartment;
        }    
    }
}
