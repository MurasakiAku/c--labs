using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppNew.Model
{
     public class ClassSeller
    {
        public int IdSeller { get; set; }
        public string _firstName { get; set; }
        public string _lastName { get; set; }
        public string _fatherland { get; set; }


        // public virtual ICollection<ClassSelleCategory> Categories { get; set; }
        //public ClassSeller()
        //{

        //}
        public int IdCategory { get; set; }
        public virtual ClassSelleCategory ClassSelleCategory { get; set; }
 

    }
}
