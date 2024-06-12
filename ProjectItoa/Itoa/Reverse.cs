using System;
using System.Collections.Generic;

namespace Itoa
{
    public class UtilityClass
    {
        // A utility function to reverse a string
        public static string Reverse(List<char> charArray) 
        { 
            int start = 0; 
            // can't use built in function .Reverse per assessment rules
            int end = charArray.Count - 1;
            while (start < end) 
            { 
                char temp = charArray[start];
                charArray[start] = charArray[end];
                charArray[end] = temp;
                start++; 
                end--; 
            } 

            return new string(charArray.ToArray());
        }
    }
}