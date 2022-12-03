using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_KazanovAlexandr
{
    public class Char
    {
        public void OperatorsCheck(char left, char right)
        {
            char result;
            bool boolResult;

            //Arithmetic operators

            result = ++left;
            result = left++;
            result = (char)+left;
            result = --left;
            result = left--;
            result = (char)-left;
            result = (char)(left * right);
            result = (char)(left / right);
            result = (char)(left % right);
            result = (char)(left + right);
            result = (char)(left - right);

            //Logic operators 

            result = (char)(left & right);
            //result = left && right;       Not applicable
            result = (char)(left | right);
            //result = left || right;       Not applicable    
            result = (char)(left ^ right);
            result = (char)~left; 

            //Shift operators 

            result = (char)(left << right);    
            result = (char)(left >> right);

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
