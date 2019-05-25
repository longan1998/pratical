using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            List<Product> product = new List<Product>();



            MobilePhone mobile1 = new MobilePhone(1, "Iphone 1", 1.3, "Long");

            MobilePhone mobile2 = new MobilePhone(2, "Iphone 2", 2.3, "Long");

            MobilePhone mobile3 = new MobilePhone(3, "Iphone 3", 3.3, "Long");

            Book book1 = new Book(1, "Sach 1", 8.0, "Book");

            Book book2 = new Book(2, "Sach 2", 9.0, "Book");

            Book book3 = new Book(2, "Sach 3", 10.0, "Book");

            product.Add(mobile1);

            product.Add(mobile2);

            product.Add(mobile3);

            product.Add(book1);

            product.Add(book2);

            product.Add(book3);
            foreach (Product item in product)
            {
                result += item.price;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }

    }
}
