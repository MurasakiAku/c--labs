using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppNew.Model
{
    public class SelleCategory
    {
        public int Id { get; set; }
        public string SellerCategory { get; set; }
       // public int SellerId { get; set; }

       // public ClassrSeller ClassSeller { get; set; }
        public virtual ICollection<Seller> Sellers { get; set; }
        //public ClassSelleCategory()
        //{

        //}
    }
}
