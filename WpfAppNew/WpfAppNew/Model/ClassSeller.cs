using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppNew.Model
{
     internal class ClassSeller
    {
        public int IdSeller { get; set; }
        public string _firstName { get; set; }
        public string _lastName { get; set; }
        public string _fatherland { get; set; }

        public ClassSeller(string _firstName, string _lastName, string _fatherland)
        {
            this._firstName = _firstName;
            this._lastName = _lastName;
            this._fatherland = _fatherland;
        }
        public ClassSeller()
        {
            _firstName = "name";
            _lastName = "lastname";
            _fatherland = "fstherland";
        }
    }
}
