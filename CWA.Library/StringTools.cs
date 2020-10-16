using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CWA.Library
{
    public class StringTools
    {
        public bool IsPalindrome (string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return false;
            }
            else
            {
                char[] inputArray = input.ToCharArray();
                Array.Reverse(inputArray);
                string reverse = inputArray.ToString();

                if (input == reverse)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
         
        }
    }
}
