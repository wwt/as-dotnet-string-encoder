# WWT String Encoder

If you're applying for a .NET development position at World Wide Technology Application Services then this is the repo for you!

### Instructions

Your challenge is to implement a string encoding function that will parse input strings into the desired output strings.

BUSINESS REQUIREMENTS:
- Vowels are replaced with number: a -> 1, e -> 2, i -> 3, o -> 4, and u -> 5
- Consonants are replaced with previous letter: b -> a, c -> b, d -> c, etc.
- y is replaced with space
- space is replaced with y
- Numbers are replaced with their reverse: 1 -> 1, 23 -> 32, 1234 -> 4321
- Other characters remain unchanged (punctuation, etc.)
- All output should be lower case, regardless of input case ("Hello World" should produce the same result as "hello world")

Unit tests are provided for you to check your implementation. You are free to change *anything* about the current code so long as you accomplish the goal. You are also free to add unit tests as you see fit, but please do not change the existing tests. Make it read and function the way you want it to, but bear in mind we’re looking for people who understand what best industry practices look like in .NET.

### FAQ (click to expand):
<details>
  <summary>Q:  What if I want to use 3rd party libraries?</summary>

  A: Do it! You can change **anything** about the current code so long as you accomplish the overall goal, and pass the tests.  If there's a library that will help you get the job done, use it!
</details>

<details>
  <summary>Q:  This was built with a different version of .NET core than I use, what do I do?</summary>

  A: Feel free to update the version of .NET that you use, however if you have to make changes to the test code to accommodate the new version please make a note of that in your submission.
</details>

<details>
  <summary>Q:  What if I want to go above and beyond?</summary>

  A: There'll be plenty of time in later interviews to showcase your skills so don't feel that you have to spend too much time on the problem. We are only looking to see your problem solving skills and your approach to software design and architecture.
</details>