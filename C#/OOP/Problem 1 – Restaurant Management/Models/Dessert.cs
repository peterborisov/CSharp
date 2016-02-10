using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantManager.Interfaces;
using RestaurantManager.Models;

namespace Problem_1___Restaurant_Management
{
    public class Dessert : Meal, IDessert
    {     
        public Dessert(string name, decimal price, int calories, int quantityPerServing,int timeToPrepare,bool isVegan) 
            : base(name,price,calories,quantityPerServing,timeToPrepare,isVegan)
        {
            this.WithSugar = true;
        }
        public bool WithSugar { get; private set; }

        public void ToggleSugar()
        {
            this.WithSugar = this.WithSugar;
        }      
        public override string ToString()
        {
            var answer = this.WithSugar == true ? "" : "NO SUGAR";
            return string.Format("{0}{1}", answer, base.ToString());
        }
    }
}
