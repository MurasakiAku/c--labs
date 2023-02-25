using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
   public class Test3
    {
        public int test3(int year)
        {
            if (year == null)
            {
                throw new ArgumentException();
            }
            if ((year % 400 == 0) || (year % 100 != 0 && year % 4 == 0))
            {
                return 366;
            }
            else {
                return 365;
            }
        }
    }
}
