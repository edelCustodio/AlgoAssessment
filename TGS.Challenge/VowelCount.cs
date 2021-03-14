using System;

namespace TGS.Challenge
{
    /*
        Devise a function that takes a string & returns the number of 
        vowels (aeiou) in that string.

        "Hi there!" = 3
        "What do you mean?"  = 6

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class VowelCount
    {
        public int Count(string value)
        {
            if (string.IsNullOrEmpty(value))
			{
                throw new ArgumentException();

            }

            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            var str = value.ToLower().ToCharArray();
            var count = 0;

            for (var i = 0; i < vowels.Length; i++)
			{
                for (var j = 0; j < str.Length; j++)
				{
                    if (vowels[i] == str[j])
					{
                        count++;
                    }
				}
			}

            return count;
        }
    }
}
