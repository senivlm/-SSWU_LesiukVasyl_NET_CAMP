using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice_2
{// у Вас не ієрархічна структура, на жаль.
    class Department
    {
        private string name;
        private List<Product> products;

        public Department(string name)
        {
            this.name = name;
            this.products = new List<Product>();
        }

        public string Name { get { return name; } }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
