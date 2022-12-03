using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_KazanovAlexandr
{
    public class Int
    {
        public void OperatorsCheck(int left, int right)
        {
            int result;
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

            //Shift operators 

            result = left << right;
            result = left >> right;

            //Assignment operators

            result = left += right;
            result = left -= right;
            result = left *= right;
            result = left /= right;
            result = left %= right;
            result = left &= right;
            result = left |= right;
            result = left ^= right;
            result = left <<= right;
            result = left >>= right;

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
