using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    static public class Shop //static sarqenq vor menak mi hat obj karenanq sarqenq 
    {
        //dictionary unenanq key value pairi vortegh key-apranq, value-qanak
        //dictionary-n tsari nman karucvatsq e
        static private List<Supplier> suppliers = new List<Supplier>();

        static public List<Supplier> Suppliers
        {
            get
            {
                return suppliers;
            }
        }
        static private Dictionary<Product, int> products = new Dictionary<Product, int>();
        

        static public Dictionary<Product, int> Products
        {
            get
            {
                return products;
            }
        }

        //unenanq function vory supplier kavelacni mer supplieri mej
        static public void AddSupplier(Supplier s)
        {
            //vor containsy ashkhati` supplieri hamar equalsy grenq
            if (suppliers.Contains(s))
                throw new SystemException("Supplier is already registered");
            suppliers.Add(s);
        }

        static public void AddProduct(Product P)
        {
            if (products.ContainsKey(P))
                throw new SystemException("Product is already registered");
            products.Add(P, 0);
            //mutq aneluc e qanak avelanalu, hima ughghaki granceciqn
        } 

        }
    /*
    static public void Trade(Product p, int c)
    {
        if (!products.ContainsKey(p))
            throw new SystemException("Product is not defined");
        if (products[p] + c < 0)
            throw new SystemException("There is not enough product");
        products[p] += c;
    }*/
}
