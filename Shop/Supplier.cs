using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public enum City
    {
        Yerevan,
        Moscow,
        Ashtarak,
        Gyumri
    }

    public class Supplier
    {
        public string Name { get; private set; }
        public City City { get; private set; }//vorteghic vor kga
        public string Address { get; private set; }

        public Supplier( string name, City city, string address)
        {
            Name = name;
            City = city;
            Address = address;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Supplier))
                return false;
            Supplier s = obj as Supplier;
            return s.Name == Name; //&& s.City-n u s.Addresy
        }

        public override string ToString()//ete chgrenq comboboxi mej kgrvi Shop.Supplier
        {
            return Name;
        }
    }
}
