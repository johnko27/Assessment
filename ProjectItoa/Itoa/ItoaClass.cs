using Itoa; 
using System;
using System.Collections.Generic;

namespace Itoa
{
    public class ItoaClass
    {
        // in int num : decimal value
        // in inBase : convert decimal value to this Base
        // out string : new Base value as a string
        public string itoa(int num, int inBase) 
        {
            List<char> charArray = new List<char>();
            bool isNegative = false; 
            string str = string.Empty;
            long tempNum = num;

            // return empty string if base is incorrect
            if (inBase != 08 && inBase != 10 && inBase != 16)
            {
                return "Invalid Base";
            }

            // only support negative values for base 10
            if ((inBase == 08 || inBase == 16) && num < 0)
            {
                return "Invalid Negative";
            }

            // Handle 0 explicitely, otherwise empty string is printed for 0
            if (num == 0) 
            { 
                return "0";
            } 

            // negative numbers are handled only with  
            // base 10. Otherwise numbers are considered unsigned. 
            if (tempNum < 0 && inBase == 10) 
            { 
                isNegative = true; 
                tempNum = -1 * tempNum;
            } 
        
            // Process individual digits 
            while (tempNum != 0) 
            { 
                long rem = tempNum % inBase; 
                charArray.Add("0123456789abcdef"[(int)rem]);
                tempNum = tempNum / inBase; 
            } 
        
            // Reverse the string
            str = UtilityClass.Reverse(charArray);
            
            // if number is negative, append '-' 
            if (isNegative)
            { 
                str = "-" + str;
            }

            return str; 
        }
    }
}
