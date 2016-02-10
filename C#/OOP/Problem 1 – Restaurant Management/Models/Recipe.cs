using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantManager.Interfaces;
using RestaurantManager.Models;

namespace Problem_1___Restaurant_Management
{
    
    public abstract class Recipe:IRecipe
    {
        private string name;
        private decimal price;
        protected int calories;
        protected int quantityPerServing;
        protected int timeToPrepare;
        private MetricUnit unit;

        public Recipe(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare)
        {
            this.Name = name;
            this.Price = price;
            this.Calories = calories;
            this.QuantityPerServing = quantityPerServing;
            this.TimeToPrepare = timeToPrepare;
        }       
        public string Name
        {
            get { return this.name; }
             set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The <parameter> is required.");
                }
                this.name = value;
            }
        }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("The <parameter> must be positive.");
                }
                this.price = value;
            }
        }

        public int Calories 
        { get { return this.calories; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The <parameter> must be positive.");
                }
                this.calories = value;
            }
        }
        public int QuantityPerServing
        {
            get { return this.quantityPerServing; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The <parameter> must be positive.");
                }
                this.quantityPerServing = value;
            }
        }
        public MetricUnit Unit
        {
            get { return this.unit; }
            set { this.unit = value; }
        }
        public int TimeToPrepare 
        {
            get { return this.timeToPrepare; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The <parameter> must be positive.");
                }
                this.timeToPrepare = value;
            }
        }
        public override string ToString()
        {
            string answer = this.Unit == MetricUnit.Milliliters ? "ml" : "g";
            return string.Format("==  {0} == ${1:F2}\n" +
                                 "Per serving: {2} {3}, {4} kcal\n" +
                                 "Ready in {5} minutes",
                this.Name,
                this.Price,
                this.QuantityPerServing,
                answer,
                this.Calories,
                this.TimeToPrepare);
        }
    }
}
