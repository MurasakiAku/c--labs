using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
   public class Test5
    {
        public int test5(int sum, int number)
        {
            
            if (sum == null)
            {
                throw new ArgumentException();
            }
            while (number > 0)
            {
                sum = sum + number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}
