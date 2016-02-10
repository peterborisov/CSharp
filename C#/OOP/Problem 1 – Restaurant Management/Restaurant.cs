using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RestaurantManager.Interfaces;

namespace Problem_1___Restaurant_Management
{
    public class Restaurant : IRestaurant
    {
        public Restaurant(string name, string location)
        {
            this.Name = name;
            this.Location = location;
            this.Recipes = new List<IRecipe>();
        }

        public string Name { get; set; }
        public string Location { get; set; }
        public IList<IRecipe> Recipes { get; private set; }

        public void AddRecipe(IRecipe recipe)
        {
            this.Recipes.Add(recipe);
        }

        public void RemoveRecipe(IRecipe recipe)
        {
            this.Recipes.Remove(recipe);
        }

        public string PrintMenu()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("***** {0} - {1} *****", this.Name, this.Location));
            if (!this.Recipes.Any())
            {
                result.Append("No recipes... yet");
                return result.ToString();
            }
            var drinks = this.Recipes
                .Where(r => r is IDrink)
                .OrderBy(d => d.Name)
                .ToList();                       
            if (drinks.Any())
            {
                result.AppendLine("~~~~~ DRINKS ~~~~~");
                foreach (var drink in drinks)
                {
                    result.Append(drink.ToString());
                }
            }

            var salads = this.Recipes
                .Where(r => r is Salad)
                .OrderBy(d => d.Name)
                .ToList();
            if (salads.Any())
            {
                result.AppendLine("~~~~~ SALADS ~~~~~");
                foreach (var salat in salads)
                {
                    result.Append(salat.ToString());
                }
            }
            var mainC = this.Recipes
               .Where(r => r is MainCourse)
               .OrderBy(d => d.Name)
               .ToList();
            if (mainC.Any())
            {
                result.AppendLine("~~~~~ MAIN COURSES ~~~~~");
                foreach (var main in mainC)
                {
                    result.Append(main.ToString());
                }
            }

            var deserts = this.Recipes
               .Where(r => r is Dessert)
               .OrderBy(d => d.Name)
               .ToList();
            if (deserts.Any())
            {result.AppendLine("~~~~~ DESSERTS ~~~~~");
                foreach (var desert in deserts)
                { 
                    result.Append(desert.ToString());
                }
            }
            return result.ToString();
        }
    }
}


