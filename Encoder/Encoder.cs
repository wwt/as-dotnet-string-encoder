using encoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Encoder
{
    public class EncoderProcessor
    {
        public string Encode(string message)
        {
            string encoderOutputstring = encode_String(message.ToLower());
            return encoderOutputstring;
        }

        // Function to replace every vowel
        public static string encode_String(string str)
        {
            // Storing the vowels,consonants,space in the map with
            const char Space = ' ';
            IEnumerable<AlphabhetModal> iEnumReplace = new List<AlphabhetModal> {
                  new AlphabhetModal { existing = 'a', replace = '1' },
                  new AlphabhetModal { existing = 'b', replace = 'a' },
                  new AlphabhetModal { existing = 'c', replace = 'b' },
                  new AlphabhetModal { existing = 'd', replace = 'c' },
                  new AlphabhetModal { existing = 'e', replace = '2' },
                  new AlphabhetModal { existing = 'f', replace = 'e' },
                  new AlphabhetModal { existing = 'g', replace = 'f' },
                  new AlphabhetModal { existing = 'h', replace = 'g' },
                  new AlphabhetModal { existing = 'i', replace = '3' },
                  new AlphabhetModal { existing = 'j', replace = 'i' },
                  new AlphabhetModal { existing = 'k', replace = 'j' },
                  new AlphabhetModal { existing = 'l', replace = 'k' },
                  new AlphabhetModal { existing = 'm', replace = 'l' },
                  new AlphabhetModal { existing = 'n', replace = 'm' },
                  new AlphabhetModal { existing = 'o', replace = '4' },
                  new AlphabhetModal { existing = 'p', replace = 'o' },
                  new AlphabhetModal { existing = 'q', replace = 'p' },
                  new AlphabhetModal { existing = 'r', replace = 'q' },
                  new AlphabhetModal { existing = 's', replace = 'r' },
                  new AlphabhetModal { existing = 't', replace = 's' },
                  new AlphabhetModal { existing = 'u', replace = '5' },
                  new AlphabhetModal { existing = 'v', replace = 'u' },
                  new AlphabhetModal { existing = 'w', replace = 'v' },
                  new AlphabhetModal { existing = 'x', replace = 'w' },
                  new AlphabhetModal { existing = 'y', replace = Space },
                  new AlphabhetModal { existing = 'z', replace = 'y' },
                  new AlphabhetModal { existing = Space, replace = 'y' },
            };

            var numbersCheckMessage = Regex.Split(str, @"\D+");
            foreach (string numberInMessage in numbersCheckMessage.Where(str => !string.IsNullOrEmpty(str)))
            {
                str = str.Replace(numberInMessage, new string(numberInMessage.Reverse().ToArray()));
            }
            var encryptedVowelsString = string.Empty;
            // Iterate over the String
            foreach (char item in str)
            {
                char character = item;
                if (character == Space || character >= 97 && character <= 122)
                {
                    character = iEnumReplace.Where(x => x.existing == character).Select(x => x.replace).FirstOrDefault();
                }
                encryptedVowelsString += character;
            }

            return encryptedVowelsString;
        }
    }


}