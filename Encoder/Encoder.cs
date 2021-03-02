using System;
using System.Collections.Generic;
using System.Text;

namespace Encoder
{
    public class EncoderProcessor
    {
        public StringBuilder sb = new StringBuilder();
        public string Encode(string message)
        {

            //Implement your code here!
            string lowerMessage = message.ToLower();
            Stack<char> numbers = new Stack<char>();
            Queue<char> characters = new Queue<char>();
            bool isNum = false, isAlphabet = false, isSpecial = false, isVowel = false, isConsonant = false;
            foreach (char c in lowerMessage)
            {
                int charAsciiVal = c;

                string charTypeText = charType(c);
                switch (charTypeText)
                {
                    case "number": isNum = true; isAlphabet = false; isSpecial = false; break;
                    case "alphabet": isNum = false; isAlphabet = true; isSpecial = false; break;
                    case "special character": isNum = false; isAlphabet = false; isSpecial = true; break;
                }
                if (isAlphabet)
                {
                    isVowel = "aeiou".IndexOf(c) >= 0;
                    isConsonant = !isVowel;
                }

                if (charAsciiVal == 32)                     // Space
                {
                    GetElements(numbers);
                    sb.Append('y');
                    numbers.Clear();
                }
                else if (charAsciiVal == 121)              // y
                {
                    GetElements(numbers);
                    sb.Append(' ');
                    numbers.Clear();
                }
                else if (isSpecial)                       // special character
                {
                    GetElements(numbers);
                    sb.Append(c);
                    numbers.Clear();
                }
                else if (isAlphabet)
                {
                    GetElements(numbers);
                    if (isVowel)                      // Vowel   
                    {
                        sb.Append(VowelValue(c));
                    }
                    else if (isConsonant)                     // Consonant
                    {
                        sb.Append(ConsonentValue(c));
                    }

                    numbers.Clear();
                }
                else if (isNum)
                {
                    numbers.Push(c);
                }


            }
            GetElements(numbers); // ending with number
            return sb.ToString();
        }

        private char ConsonentValue(char val)
        {
            int ascii = val;
            int previousAscii = ascii - 1;
            char result = (char)previousAscii;
            return result;
        }

        private char VowelValue(char val)
        {
            switch (val)
            {
                case 'a': return '1';
                case 'e': return '2';
                case 'i': return '3';
                case 'o': return '4';
                case 'u': return '5';
                default: return '0';
            }
        }

        private string charType(int val)
        {
            if (val >= 48 && val <= 57)
            {
                return "number";
            }
            else if (val >= 97 && val <= 122)
            {
                return "alphabet";
            }
            else
            {
                return "special character";
            }
        }

        private void GetElements(Stack<char> num)
        {
            foreach (var n in num)
            {
                sb.Append(n);
            }
        }
    }
}
