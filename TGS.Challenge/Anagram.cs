using System;

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
            //Catch the ArgumentException for null values passed for Word1 and Word2
            if (string.IsNullOrEmpty(word1) || string.IsNullOrEmpty(word2))
            {
                throw new ArgumentException();
            }
             
            //Check if length of word 1 and word 2 are matching
            if (word1.Length != word2.Length)
                return false;

            char[] word1Arr = word1.ToCharArray();
            char[] word2Arr = word2.ToCharArray();

            Array.Sort(word1Arr);
            Array.Sort(word2Arr);

            return Array.Equals(word1Arr, word2Arr);
      }
    }
}
