using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace encoder.Extensions
{
    public static class Mappings
    {

        private const char Space = ' ';

        private static readonly IDictionary<char, char> AlphabetMappings = new Dictionary<char, char>();


        public static void LoadMappings()
        {
            //loading the character mappings from text file
            string _filePath = Path.GetDirectoryName(System.AppDomain.CurrentDomain.BaseDirectory);
            var mappings = File.ReadLines(_filePath + "\\CharacterMappings.txt");

            foreach (var mapping in mappings)
            {
                var charactermapping = mapping.Split(',');
                var key = charactermapping[0].ToCharArray();
                var value = charactermapping[1].ToCharArray();
                if (key.Length == 1 && value.Length == 1)
                    AlphabetMappings.Add(key[0], value[0]);
            }
        }

        public static bool CheckIfSpaceOrAlphabet(this char character)
        {
            return character == Space || character >= 97 && character <= 122;
        }

        public static char ReturnEncryptedValueForSpaceOrAlphabet(this char character)
        {
            return AlphabetMappings.ContainsKey(character) ? AlphabetMappings[character] : '\0';
        }
    }
}


