using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppNew.Model
{
    public class SalesContnt
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public int Discount { get; set; }

        public virtual ICollection<Product> Product { get; set; }
        public SalesContnt()
        {
            Product = new List<Product>();
        }
    }
}
