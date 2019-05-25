using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical
{
    public abstract class Product
    {
        public int id;
        public String name;
        public Double price;
        public String producer;
        protected Product()
        {
        }

        public  Product(int id, string name, double price, string producer)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.producer = producer;
        }
        public abstract double computeTax();


    }



}
