using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Encoder
{
    public static class HelperUtilities
    {
        public static bool IsAlphabet(this char alphabet)
        {
            return (alphabet >= 'a' && alphabet <= 'z') || (alphabet >= 'A' && alphabet <= 'Z');
        }

        public static string ReverseNumberFromString(this string inputData)
        {
            MatchCollection numbers = Regex.Matches(inputData, @"\d+");

            StringBuilder lowercaserOutput = new StringBuilder(inputData);

            foreach (Match item in numbers)
            {
                char[] charArray = item.Value.ToCharArray();
                Array.Reverse(charArray);
                lowercaserOutput.Replace(item.Value, new string(charArray));
            }

            return lowercaserOutput.ToString();
        }
    }
}
