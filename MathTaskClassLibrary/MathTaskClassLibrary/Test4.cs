using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MathTaskClassLibrary
{
    public class Test4
    {
        public bool test4(string email)
        {
            if (email == null)
            { throw new ArgumentException(); }
            Regex regex = new Regex(@"[.+@+]");
            if (regex.IsMatch(email))
            {
                return true;
            }

            else { return false; }
        }
    }
}
