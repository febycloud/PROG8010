using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
   public class Product
    {
        public int ID { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public Product(int id,string des,decimal pri)
        {
            this.ID = id;
            this.Description = des;
            this.Price = pri;
        }
        public override string ToString()
        {
            return ID + "|" + Description + "|" + Price;
        }
    }
}
