using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_KazanovAlexandr
{
    public class UShort
    {
        public void OperatorsCheck(ushort left, ushort right)
        {
            ushort result;
            bool boolResult;

            //Arithmetic operators

            result = ++left;
            result = left++;
            result = (ushort)+left;
            result = --left;
            result = left--;
            result = (ushort)-left;
            result = (ushort)(left * right);
            result = (ushort)(left / right);
            result = (ushort)(left % right);
            result = (ushort)(left + right);
            result = (ushort)(left - right);

            //Logic operators

            result = (ushort)(left & right);
            //result = (ushort)(left && right);     Not applicable
            result = (ushort)(left | right);
            //result = (ushort)(left || right);     Not applicable
            result = (ushort)(left ^ right);
            result = (ushort)(~left);

            //Shift operators 

            result = (ushort)(left << right);
            result = (ushort)(left >> right);

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
