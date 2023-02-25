using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTaskClassLibrary
{
    public class Test2
    {
        public double[] test2(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new System.AggregateException();
            }
            double D = (b * b) - (4 * a * c);
            double x1;
            double x2;
            if (D > 0 )
            {
                x1 = (-b + Math.Sqrt(D) / (2 * a));
                x2 = (-b - Math.Sqrt(D) / (2 * a));
                
                return new double[2] { x1, x2 };

            }
            if (D == 0)
            {
                x1 = (-b + Math.Sqrt(D) / (2 * a));
                return new double[1] { x1};
            }
            else
            {
                return new double[0];
            }

            
           
        }
    }
}
