using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Book_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book=new Book("pod igoto","vazov",15.90);
            Console.WriteLine(book);
            GoldenEditionBook golden =new GoldenEditionBook("golden igo","golden vazov",22.90);
            Console.WriteLine(golden);
        }
    }
}
