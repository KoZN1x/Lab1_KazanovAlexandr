using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_KazanovAlexandr
{
    public class Bool
    {
        public void OperatorsCheck(bool left, bool right)
        {
            bool result;

            //Arithmetic operators are not applicable to this data type

            /*result = ++left; 
            result = left++; 
            result = +left; 
            result = --left; 
            result = left--; 
            result = -left;  
            result = left * right; 
            result = left / right;
            result = left % right;
            result = left + right;
            result = left - right;*/

            //Logic operators

            result = left & right;
            result = left && right;
            result = left | right;
            result = left || right;
            result = left ^ right;
            //result = ~left;          Not applicable

            //Shift operators are not applicable to this data type

            /*result = left << right;
            result = left >> right;*/

            //Assignment operators

            /*result = left += right; 
            result = left -= right;
            result = left *= right;     Are not applicable
            result = left /= right;
            result = left %= right;*/
            result = left &= right;
            result = left |= right;
            result = left ^= right;
            /*result = left <<= right;  Are not applicable
            result = left >>= right;*/

            // Comparison operators

            result = left == right;
            result = left != right;
            /*result = left > right;
            result = left < right;       Are not applicable
            result = left <= right;
            result = left >= right;*/
        }
    }
}
