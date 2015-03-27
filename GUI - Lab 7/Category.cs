using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI___Lab_7
{
    class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public Category(int id, string name)
        {
            CategoryID = id;
            CategoryName = name;
        }
    }
}
