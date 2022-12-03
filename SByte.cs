using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_KazanovAlexandr
{
    public class SByte
    {
        public void OperatorsCheck(sbyte left, sbyte right)
        {
            sbyte result;
            bool boolResult;

            //Arithmetic operators

            result = ++left;
            result = left++;
            result = (sbyte)+left;
            result = --left;
            result = left--;
            result = (sbyte)-left;
            result = (sbyte)(left * right);
            result = (sbyte)(left / right);
            result = (sbyte)(left % right);
            result = (sbyte)(left + right);
            result = (sbyte)(left - right);

            //Logic operators

            result = (sbyte)(left & right);
            //result = (byte)(left && right);   Not applicable
            result = (sbyte)(left | right);
            //result = (byte)(left || right);   Not applicable
            result = (sbyte)(left ^ right);
            result = (sbyte)(~left);

            //Shift operators 

            result = (sbyte)(left << right);
            result = (sbyte)(left >> right);

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
