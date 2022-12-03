using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_KazanovAlexandr
{
    public class Byte
    {
        public void OperatorsCheck(byte left, byte right)
        {
            byte result;
            bool boolResult;

            //Arithmetic operators

            result = ++left;
            result = left++;
            result = (byte)+left;
            result = --left;
            result = left--;
            result = (byte)-left;
            result = (byte)(left * right);
            result = (byte)(left / right);
            result = (byte)(left % right);
            result = (byte)(left + right);
            result = (byte)(left - right);

            //Logic operators

            result = (byte)(left & right);
            //result = (byte)(left && right);   Not applicable
            result = (byte)(left | right);
            //result = (byte)(left || right);   Not applicable
            result = (byte)(left ^ right);
            result = (byte)(~left);

            //Shift operators 

            result = (byte)(left << right);
            result = (byte)(left >> right);

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
