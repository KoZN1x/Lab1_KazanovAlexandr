using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_KazanovAlexandr
{
    public class Long
    {
        public void OperatorsCheck(long left, long right)
        {
            long result;
            bool boolResult;

            //Arithmetic operators

            result = ++left;
            result = left++;
            result = +left;
            result = --left;
            result = left--;
            result = -left;
            result = left * right;
            result = left / right;
            result = left % right;
            result = left + right;
            result = left - right;

            //Logic operators

            result = left & right;
            //result = left && right;    Not applicable
            result = left | right;
            //result = left || right;    Not applicable
            result = left ^ right;
            result = ~left;

            //Shift operators are not applicable to this data type

            /*result = left << right;    
            result = left >> right;*/

            //Assignment operators

            result = left += right;
            result = left -= right;
            result = left *= right;
            result = left /= right;
            result = left %= right;
            result = left &= right;
            result = left |= right;
            result = left ^= right;
            /*result = left <<= right;   Are not applicable
            result = left >>= right;*/

            // Comparison operators

            boolResult = left == right;
            boolResult = left != right;
            boolResult = left > right;
            boolResult = left < right;
            boolResult = left <= right;
            boolResult = left >= right;
        }
    }
}
