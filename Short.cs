using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_KazanovAlexandr
{
    public class Short
    {
        public void OperatorsCheck(short left, short right)
        {
            short result;
            bool boolResult;

            //Arithmetic operators

            result = ++left;
            result = left++;
            result = (short)+left;
            result = --left;
            result = left--;
            result = (short)-left;
            result = (short)(left * right);
            result = (short)(left / right);
            result = (short)(left % right);
            result = (short)(left + right);
            result = (short)(left - right);

            //Logic operators

            result = (short)(left & right);
            //result = (short)(left && right);   Not applicable
            result = (short)(left | right);
            //result = (short)(left || right);   Not applicable
            result = (short)(left ^ right);
            result = (short)(~left);

            //Shift operators 

            result = (short)(left << right);
            result = (short)(left >> right);

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
