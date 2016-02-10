using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantManager.Interfaces;
using RestaurantManager.Models;

namespace Problem_1___Restaurant_Management
{

    public class MainCourse : Meal, IMainCourse
    {
        private string type;

        public MainCourse(string name, decimal price, int calories, int quantityPerServing, int timeToPrepare, bool isVegan, string type)
            : base(name, price, calories, quantityPerServing, timeToPrepare, isVegan)
        {
            this.Type = ParseMainCourseType(type).ToString();
        }
        private static MainCourseType ParseMainCourseType(string type)
        {
            switch (type)
            {
                case "Soup":
                    return MainCourseType.Soup;
                case "Entree":
                    return MainCourseType.Entree;
                case "Pasta":
                    return MainCourseType.Pasta;
                case "Side":
                    return MainCourseType.Side;
                case "Meat":
                    return MainCourseType.Meat;
                default:
                    return MainCourseType.Other;
            }
        }
        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }
        public override string ToString()
        {
            return string.Format("{0}\nType: {1}\n", this.Type, base.ToString());
        }
    }
}

