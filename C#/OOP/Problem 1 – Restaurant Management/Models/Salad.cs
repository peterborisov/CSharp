using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantManager.Interfaces;
using RestaurantManager.Models;

namespace Problem_1___Restaurant_Management
{
    public class Salad : Meal, ISalad
    {
        private const bool DefaultSaladVegan = true;
        public Salad(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool containsPasta)
            : base(name, price, calories, quantityPerServing, timeToPrepare, DefaultSaladVegan)
        {
            this.ContainsPasta = containsPasta;
        }
        public bool ContainsPasta { get; set; }

        public override string ToString()
        {
            string answer = this.ContainsPasta == true ? "yes" : "no";
            return string.Format("{0}{1}\nContains pasta: {2}\n",IsVegan?"[VEGAN] ":"", base.ToString(),answer);
        }       
    }
}
