using System;

namespace Encoder
{
    public class EncoderProcessor
    {
        public string Encode(string message)
        {
            try
			{
				if(message.Length>0)
				{
					string output = message.ToLower();
					output = Regex.Replace(output,@"\d+",s=> new string(s.Value.Reverse().ToArray()));
					output = new string(output.Select(s => (s=='a'?'1':s=='e'?'2':s=='i'?'3':s=='o'?'4':s=='u'?'5':s)).ToArray());		
					output = new string(output.Select(s=> (s=='y'?' ':s==' '?'y':s)).ToArray());
					output = new string(output.Select(s=> (s>='a'&s<='z'&s!='y'?(char)(s-1):s)).ToArray());
					message = output;
				}
				else
				{
					message="Please enter a valid stentence";
				}
			}
			catch(Exception ex)
			{
				message = ex.Message;
			}
			return message;
        }
    }
}