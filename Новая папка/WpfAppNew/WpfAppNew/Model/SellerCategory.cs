using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppNew.Model
{
    public class SellerCategory
    {
        public int Id { get; set; }
        public string SellerCategories { get; set; }
        public virtual ICollection<Seller> Sellers { get; set; }

        public SellerCategory()
        { 
            Sellers = new List<Seller>();
        }
        
        //public ClassSelleCategory()
        //{

        //}
        // public int SellerId { get; set; }

        // public ClassrSeller ClassSeller { get; set; }
    }
}
