using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI___Lab_7
{
    class Product
    {
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public float UnitPrice { get; set; }
        public bool OnSale { get; set; }

        public Product(string name, int id, float price,  bool sale)
        {
            ProductName = name;
            CategoryID = id;
            UnitPrice = price;
            OnSale = sale;
        }
    }
}
