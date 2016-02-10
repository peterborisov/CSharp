using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantManager.Interfaces;
using RestaurantManager.Models;

namespace Problem_1___Restaurant_Management
{
    public abstract class Meal : Recipe, IMeal
    {
        private bool isVegan;


        public Meal(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan)
            : base(name,price,calories,quantityPerServing,timeToPrepare)
        {
            this.IsVegan = isVegan;
            this.Unit = MetricUnit.Grams;
        }                         
        public bool IsVegan { get; private set; }
        public void ToggleVegan()
        {
            this.IsVegan = !this.isVegan;
        }
        public override string ToString()
        {
            var answer = this.isVegan == true ? "VEGAN" : "";
            return string.Format("{0}{1}",  answer,base.ToString());
        }
    }
}
