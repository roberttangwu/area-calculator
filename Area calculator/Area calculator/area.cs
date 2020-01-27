using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// this code is modular the code and show let the user understand how the work
namespace Area_calculator
{
    public class area

    {
        // this function is show how the rectangle work
        public double rectangle(double num1, double num2)
        {
            return num1 * num2;
        }
        // thhis function is show how the triangle work
        public double triangle(double num1, double num2)
        {
           
            return num1 * num2 / 2;
            
        }
        // this function is show how the circle work
        public double circle(double num1)
        {
            return num1 * num1 * 3.14;
        }
        
    }
}
