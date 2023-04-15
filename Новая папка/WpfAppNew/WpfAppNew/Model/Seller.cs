using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppNew.Model
{
    public class Seller
    {
       
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Fatherland { get; set; }


        // public virtual ICollection<ClassSelleCategory> Categories { get; set; }
        
        public int SellerCategoryId { get; set; }
        public virtual SellerCategory SellerCategory { get; set; }


    }
}
