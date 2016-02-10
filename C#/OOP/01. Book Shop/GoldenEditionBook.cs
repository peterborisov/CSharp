using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Book_Shop
{
    public class GoldenEditionBook : Book
    {
        private double price;
        public GoldenEditionBook(string title, string autor, double price)
            : base(title, autor, price)
        {
            this.Price = price;
        }
        public override double Price
        {
            get
            {
                price =price+(price * 30) / 100;
                return this.price;
            }
            set
            {            
                this.price = value;
            }
        }
    }
}
