using System;
using Xunit;
using System.Diagnostics;
using Encoder;

namespace Service.Tests
{
    /************** Rules
    //vowels are replaced with number: a -> 1, e -> 2, i -> 3, o -> 4, and u -> 5
    //consonants are replaced with previous letter: b -> a, c -> b, d -> c, etc.
    //y is replaced with space
    //space is replaced with y
    //numbers are replaced with their reverse: 1 -> 1, 23 -> 32, 1234 -> 4321
    //other characters remain unchanged (punctuation, etc.)
    //all output should be lower case, regardless of input case ("Hello World" should produce the same result as "hello world")
    *****/
    public class EncoderSpec
    {
        [Theory]
        [InlineData("Hello World! 1234", "g2kk4yv4qkc!y4321")]
        [InlineData("123B456", "321a654")]
        [InlineData("Have you tried turning it off and on again?", "g1u2y 45ysq32cys5qm3mfy3sy4eey1mcy4my1f13m?")]
        [InlineData("The quick brown fox jumps over the lazy dog", "sg2yp53bjyaq4vmye4wyi5lory4u2qysg2yk1y yc4f")]
        [InlineData(@"Why haven\‘t you finished the exercise yet?” said Nate.", @"vg yg1u2m\‘sy 45ye3m3rg2cysg2y2w2qb3r2y 2s?”yr13cym1s2.")]
        [InlineData(@"You\’ve never heard of the Millennium Falcon? It\‘s the ship that made the Kessel Run in less than 12 parsecs.", @" 45\’u2ym2u2qyg21qcy4eysg2yl3kk2mm35lye1kb4m?y3s\‘rysg2yrg3oysg1syl1c2ysg2yj2rr2kyq5my3myk2rrysg1my21yo1qr2br.")]
        [InlineData(@"The one from the village, FN2187", @"sg2y4m2yeq4lysg2yu3kk1f2,yem7812")]
        public void Encoder_HashesStringCorrectly(string toEncode, string expected)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            Assert.Equal(expected, EncoderProcessor.Encode(toEncode));
            stopWatch.Stop();
            Console.WriteLine("Memory (MB): " + (GC.GetTotalMemory(false) * 0.000001) );
            Console.WriteLine("Runtime: " + stopWatch.ElapsedMilliseconds + "ms");
        }
    }
}