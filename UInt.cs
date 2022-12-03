using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_KazanovAlexandr
{
    internal class UInt
    {
        public void OperatorsCheck(uint left, uint right)
        {
            uint result;
            bool boolResult;

            //Arithmetic operators

            result = ++left;
            result = left++;
            result = +left;
            result = --left;
            result = left--;
            result = (uint)-left;
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
