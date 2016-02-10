using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32.SafeHandles;
using RestaurantManager.Interfaces;
using RestaurantManager.Models;

namespace Problem_1___Restaurant_Management
{
    public class Drink : Recipe, IDrink
    {
        private MetricUnit unit;
        private bool isCarbonated;

        public Drink(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isCarbonated)
            : base(name,price,calories,quantityPerServing,timeToPrepare)
        {
            this.IsCarbonated = isCarbonated;
            this.Unit = MetricUnit.Milliliters;
        }

        public MetricUnit Unit
        {
            get { return this.unit; }
            set { this.unit = value; }
        }
        public int Calories
        {
            get { return this.calories; }
            set
            {
                if (value > 100)
                {
                    throw new ArgumentException("Calories must be less then 100");
                }
                this.calories = value;
            }
        }           
        public int TimeToPrepare
        {
            get { return this.timeToPrepare; }
            set
            {
                if (value > 20)
                {
                    throw new ArgumentException("Time must be less then 20 minutes");
                }
                this.timeToPrepare = value;
            }
        }
        public bool IsCarbonated
        {
            get { return this.isCarbonated; }
            set { this.isCarbonated = value; }
        }
       
        public override string ToString()
        {
            var answer = this.IsCarbonated == true ? "yes" : "no";

            return string.Format("{0}\nCarbonated: {1}\n", base.ToString(), answer);
        }
    }
}