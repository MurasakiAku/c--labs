using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppNew.Model
{
    public class ClassSelleCategory
    {
        public int IdCategory { get; set; }
        public string SelleCategory { get; set; }

        public virtual ICollection<ClassSeller> ClassSellers { get; set; }
        public ClassSelleCategory()
        {

        }
    }
}
