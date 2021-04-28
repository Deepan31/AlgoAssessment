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
            //Checking Null value passed for string value
            if(string.IsNullOrEmpty(value))
            {
                throw new ArgumentException();
            }

            char[] valArr = value.ToCharArray();
            int vowelCount = 0;

            for (int i = 0; i < value.Length; i++)
            {
                //Checking if the string passed contains vowel alphabets
                if (valArr[i] == 'a' || valArr[i] == 'e' || valArr[i] == 'i' || valArr[i] == 'o' || valArr[i] == 'u'  ||
                    valArr[i] == 'A' || valArr[i] == 'E' || valArr[i] == 'I' || valArr[i] == 'O' || valArr[i] == 'U')
                {
                    vowelCount++;
                }
            }
            return vowelCount;
        }
    }
}
