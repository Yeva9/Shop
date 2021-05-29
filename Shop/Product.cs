using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Product
    {
        public string Name { get; private set; }
        public int Price { get; private set; }
        public Supplier Supplier { get; private set; }
        public string Mark { get; private set; }

        public Product(string name, int price, Supplier supplier, string mark)
        {
            Name = name;
            Price = price;
            Supplier = supplier;
            Mark = mark;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Product))
                return false;
            Product p = obj as Product;
            return p.Name == Name
                && p.Price == Price
                && p.Mark == Mark
                // && p.Supplier == Supplier; skhal e qani vor == y sahmanats chi, chishty`
                && Supplier.Equals(p.Supplier);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
