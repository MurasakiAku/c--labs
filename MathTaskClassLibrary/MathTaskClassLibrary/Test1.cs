using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class Test1
    {
        public string test1(int n)
        {
            if (n <=1 || n >= 26)
                throw new System.ArgumentException();

            char[] ab = Enumerable.Range(0, n).Select((x, i) => (char)('A' + i)).ToArray();
            return new string(ab);
        }
        
    }
}
