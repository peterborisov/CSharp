using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Book_Shop
{
    public class Book
    {
        private string title;
        private string autor;
        private double price;

        public Book(string title, string autor, double price)
        {
            this.Title = title;
            this.Author = autor;
            this.Price = price;
        }
        public string Title
        {
            get { return this.title; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Title can't be null");
                }
                this.title = value;
            }
        }

        public string Author
        {
            get { return this.autor; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Author can't be null");
                }
                this.autor = value;
            }
        }

        public virtual double Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value can't be negative");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("-Type {0} {1}", this.GetType().Name, Environment.NewLine);
            output.AppendFormat("-Title {0} {1}", this.Title, Environment.NewLine);
            output.AppendFormat("-Author {0} {1}", this.Author, Environment.NewLine);
            output.AppendFormat("-Price {0:F2}", this.Price);
            return output.ToString();
        }
    }

}
