using System;
using System.Text;

namespace Encoder
{
    public class EncoderProcessor
    {
        public string Encode(string message)
        {
            //Reverse numbers present in the message
            string outputWithReverseNumbers = message.ReverseNumberFromString();

            StringBuilder lowercaseOutput = new StringBuilder();

            lowercaseOutput.Append(outputWithReverseNumbers.ToLower());

            for (int i = 0; i < lowercaseOutput.Length; i++)
            {
                switch (lowercaseOutput[i])
                {
                    //replace a with 1
                    case 'a':
                        lowercaseOutput[i] = '1';
                        break;
                    //replace e with 2
                    case 'e':
                        lowercaseOutput[i] = '2';
                        break;
                    //replace i with 3
                    case 'i':
                        lowercaseOutput[i] = '3';
                        break;
                    //replace o with 4
                    case 'o':
                        lowercaseOutput[i] = '4';
                        break;
                    //replace u with 5
                    case 'u':
                        lowercaseOutput[i] = '5';
                        break;
                    //replace y with space
                    case 'y':
                        lowercaseOutput[i] = ' ';
                        break;
                    //replace space with y
                    case ' ':
                        lowercaseOutput[i] = 'y';
                        break;
                    default:
                        //check if character is alphabet
                        if (lowercaseOutput[i].IsAlphabet())
                            lowercaseOutput[i] = (char)(lowercaseOutput[i] - 1);
                        break;
                }
            }

            return lowercaseOutput.ToString();
        }
    }
}