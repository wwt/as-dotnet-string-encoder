using System.Collections.Generic;

namespace encoder
{
    public static class Extensions
    {
        private const char Space = ' ';

        private static readonly IDictionary<char, char> AlphabetEncryptionMap = new Dictionary<char, char>
        {
            {'a', '1'}, {'b', 'a'}, {'c', 'b'}, {'d', 'c'}, {'e', '2'}, {'f', 'e'}, {'g', 'f'},
            {'h', 'g'}, {'i', '3'}, {'j', 'i'}, {'k', 'j'}, {'l', 'k'}, {'m', 'l'}, {'n', 'm'},
            {'o', '4'}, {'p', 'o'}, {'q', 'p'}, {'r', 'q'}, {'s', 'r'}, {'t', 's'}, {'u', '5'},
            {'v', 'u'}, {'w', 'v'}, {'x', 'w'}, {'y', Space}, {'z', 'y'}, {Space, 'y'}
        };

        public static bool IsSpaceOrAlphabet(this char character)
        {
            return character == Space || character >= 97 && character <= 122;
        }

        public static char ToEncryptedValueForSpaceOrAlphabet(this char character)
        {
            return AlphabetEncryptionMap.ContainsKey(character) ? AlphabetEncryptionMap[character] : '\0';
        }
    }
}