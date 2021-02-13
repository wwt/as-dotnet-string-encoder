using System.Linq;
using System.Text.RegularExpressions;
using encoder;

namespace Encoder
{
    public static class EncoderProcessor
    {
        public static string Encode(string message)
        {
            // Requirements:
            // ------------ //
            // 1. Vowels are replaced with number: a -> 1, e -> 2, i -> 3, o -> 4, and u -> 5
            // 2. Consonants are replaced with previous letter: b->a, c->b, d->c, etc.
            // 3. y is replaced with space
            // 4. space is replaced with y
            // 5. Numbers are replaced with their reverse: 1-> 1, 23-> 32, 1234-> 4321
            // 6. Other characters remain unchanged(punctuation, etc.)
            // 7. All output should be lower case, regardless of input case ("Hello World" should produce the same result as "hello world")

            message = message.ToLower();

            string encryptedMessage = EncryptAlphabets(message);

            return EncryptNumbers(message, encryptedMessage);
        }

        private static string EncryptAlphabets(string message)
        {
            var encryptedMessage = string.Empty;

            foreach (char item in message)
            {
                char character = item;

                if (character.IsSpaceOrAlphabet())
                {
                    character = character.ToEncryptedValueForSpaceOrAlphabet();
                }

                encryptedMessage += character;
            }

            return encryptedMessage;
        }

        private static string EncryptNumbers(string message, string encryptedMessage)
        {
            var numbersInMessage = Regex.Split(message, @"\D+");
            foreach (string numberInMessage in numbersInMessage.Where(str => !string.IsNullOrEmpty(str)))
            {
                encryptedMessage = encryptedMessage.Replace(numberInMessage, GetReverseOfNumber(numberInMessage));
            }

            return encryptedMessage;
        }

        private static string GetReverseOfNumber(string numberInMessage)
        {
            var reverseOfNumber = string.Empty;
            int numberLength = numberInMessage.Length - 1;
            while (numberLength >= 0)
            {
                reverseOfNumber += numberInMessage[numberLength];
                numberLength--;
            }

            return reverseOfNumber;
        }
    }
}