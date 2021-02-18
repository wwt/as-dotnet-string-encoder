using System;

namespace Encoder
{
    public class EncoderProcessor
    {
        public string Encode(string message)
        {
            try
            {
                // Convert fro upper to lower case...
                   message = message.ToLower();

                // Reverse Number...
                   string[] splitNumbers = Regex.Split(message, @"[^\d]"); 
                   if(splitNumbers.Length > 0)
                   {
                       foreach(var splitNumber in splitNumbers)
                       {
                           if(!string.IsNullOrEmpty(splitNumber))
                           {
                               char[] charArrayNumber = splitNumber.ToCharArray();
                               Array.Reverse(charArrayNumber);
                               message = message.Replace(splitNumber, new string(charArrayNumber));
                           }
                       }
                   }

                // Replace Vowels to Numbers...
                   message = message.Replace("a","1").Replace("e","2").Replace("i","3").Replace("o","4").Replace("u","5");

                // Relace y to Space and Vice-Versa...
                    var replaceSpaces = message.Split(' ');
                    if(replaceSpaces.Length > 0)
                    {
                        for(int i = 0; i < replaceSpaces.Length; i++)
                        {
                            replaceSpaces[i]= replaceSpaces[i].Replace("y", " ");
                        }
                        message = string.Join("y", replaceSpaces);
                    }
                    else
                        message.Replace("y"," ");

                // Replace Consontants...
                    char[] charArrayCons = message.ToCharArray();
                    for(int i = 0; i < charArrayCons.Length; i++)
                    {
                         if(!Char.IsDigit(charArrayCons[i]) && !Char.IsSymbol(charArrayCons[i]) && !Char.IsPunctuation(charArrayCons[i])
                              && charArrayCons[i] !='y' && charArrayCons[i] !=' ')
                         {
                             charArrayCons[i]= (char) (charArrayCons[i] - 1);
                         }
                    }
                 return message = new String(charArrayCons);
            }
            catch
            {
              throw new NotImplementedException();
            }
        }
    }
}
