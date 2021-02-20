using encoder.Extensions;
using System.Linq;
using System.Text.RegularExpressions;

namespace Encoder
{
    public static class EncoderProcessor
    {
        static EncoderProcessor()
        {
            Mappings.LoadMappings();
        }
        public static string Encode(string message)
        {

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

                if (character.CheckIfSpaceOrAlphabet())
                {
                    character = character.ReturnEncryptedValueForSpaceOrAlphabet();
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