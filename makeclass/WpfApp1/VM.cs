using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
   public class VM
    {
        public BindingList<Product> Products { get; set; } = new BindingList<Product>();

        public Product SelectProduct { get; set; }
        public VM()
        {
           Product p = new Product(2, "magazine", 6m);
           Products.Add(p);
           p = new Product(3, "book", 7.6m);
           Products.Add(p);

        }

    }
}
