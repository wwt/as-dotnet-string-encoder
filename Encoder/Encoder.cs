using System;

namespace Encoder
{
    public class EncoderProcessor
    {
        public string Encode(string message)
        {
            // Convert from upper to lower case... 
            message = message.ToLower();

            // Reserve Number in a string... 
             string[] splitNumbers = Regex.Split(message,@"[^\d]");
             if(splitNumbers.Length > 0)
             {
               foreach(var splitNumbers in splitNumbers)
               {
                  if(!string.IsNullOrEmpty(splitNumber))
                   {
                      char[] charArray = splitNumber.ToCharArray();
                      Array.Reverse(charArray);
                      message = message.Replace(splitNumber, new string(charArray));
                   }
               } 
             }

            // Replace Vowels to Numbers... 
                message = message.Replace("a", "1").Replace("e", "2").Replace("i", "3").Replace("o", "4").Replace("u", "5");

            // Replace y to Space and Wise Versa... 
                var replaceSpaces = message.Split(' ');
                 if(replaceSpaces.Length > 0)
                 {
                   for(int i = 0; i < replaceSpaces.Length; i++)
                    {
                      replaceSpaces[i] = replaceSpaces[i].Replace("y", " ");
                    } 
                    message = string.Join("y",replaceSpaces);
                 }
                 else
                   message.Replace("y", " ");

             // Replace Consonants... 
               char[] charArrayConsontants = message.toCharArray();
               for(int i = 0; i < charArrayConsontants.Length; i++)
                 {
                    if(!Char.IsDigit(charArrayConsontants[i]) &&  )
                 } 
            throw new NotImplementedException();
        }
    }
}
