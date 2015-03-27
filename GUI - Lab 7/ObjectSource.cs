using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI___Lab_7
{
    class ObjectSource
    {
        private List<Category> _categories;
        private List<Product> _products;

        public ObjectSource()
        {
            // List of Categorys
            // id, name
            _categories = new List<Category>();
            _categories.Add(new Category(0, "FRUITS"));
            _categories.Add(new Category(1, "VEGETABLES"));

            // List of Fruit Products
            // name, id, price, sale
            _products = new List<Product>();
            _products.Add(new Product("Apple", 0, 2.99f, false));
            _products.Add(new Product("Orange", 0, .92f, true ));
            _products.Add(new Product("Banana", 0, .42f, true ));
            _products.Add(new Product("Pineapple", 0, 2.77f, false ));
            _products.Add(new Product("Pear", 0, 1.48f, false ));

            // List of Vegetable Products
            // name, id, price, sale
            _products.Add(new Product("Celery", 1, 1.39f, true ));
            _products.Add(new Product("Lettuce", 1, 1.10f, true ));
            _products.Add(new Product("Spinach", 1, 1.98f, false ));
            _products.Add(new Product("Bell Pepper", 1, 1.17f, false ));
        }

        // Returns a list of Categories
        public IList<Category> GetCategorys()
        {
            return _categories;
        }

        // Use parameter "id" to find match in Product's list and return the matched Product
        public IList<Product> GetProducts(int id)
        {
            //IEnumerable<Product> result = from p in _products where p.CategoryCode == code select p;
            var result = from p in _products where p.CategoryID == id select p;
            return result.ToList<Product>();
        }
    }
}
