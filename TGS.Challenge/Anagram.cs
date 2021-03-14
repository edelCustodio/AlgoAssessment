using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TGS.Challenge
{
  /*
        Devise a function that checks if 1 word is an anagram of another, if the words are anagrams of
        one another return true, else return false

        "Anagram": An anagram is a type of word play, the result of rearranging the letters of a word or
        phrase to produce a new word or phrase, using all the original letters exactly once; for example
        orchestra can be rearranged into carthorse.

        areAnagrams("horse", "shore") should return true
        areAnagrams("horse", "short") should return false

        NOTE: Punctuation, including spaces should be ignored, e.g.

        horse!! shore = true
        horse  !! shore = true
          horse? heroes = true

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class Anagram
    {
      public bool AreAnagrams(string word1, string word2)
      {
            var newWord1 = Regex.Replace(word1, @"\s+", "");
            newWord1 = newWord1.ToLower();
            var newWord2 = Regex.Replace(word2, @"\s+", "");
            newWord2 = newWord2.ToLower();

            if (string.IsNullOrEmpty(word1) || string.IsNullOrEmpty(word2))
			{
                throw new ArgumentException();
            }

            if (newWord1.Length != newWord2.Length)
            {
                return false;
            }

            var subWord1 = new List<char>();
            subWord1.AddRange(newWord1);
            var subWord2 = new List<char>();
            subWord2.AddRange(newWord2);
            var indexList = new List<int>();

            for (int j = 0; j < subWord1.Count; j++)
            {
                var index = subWord2.IndexOf(subWord1[j]);
                if (index != -1)
                {
                    subWord2.RemoveAt(index);
                    indexList.Add(index);
                }
                else
                {
                    return false;
                }
            }

            if (indexList.Count != subWord1.Count)
            {
                return false;
            }

            return true;
        }
    }
}
