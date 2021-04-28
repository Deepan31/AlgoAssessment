using System;

namespace TGS.Challenge
{
    /*
        Devise a function that takes an input 'n' (integer) and returns a string that is the
        decimal representation of that number grouped by commas after every 3 digits. 
        
        NOTES: You cannot use any built-in formatting functions to complete this task.

        Assume: 0 <= n < 1000000000

        1 -> "1"
        10 -> "10"
        100 -> "100"
        1000 -> "1,000"
        10000 -> "10,000"
        100000 -> "100,000"
        1000000 -> "1,000,000"
        35235235 -> "35,235,235"

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class FormatNumber
    {
        public string Format(int value)
        {
            string res = string.Empty;

            int len = value.ToString().Length;

            string input = value.ToString();

            char[] chrArray = input.ToCharArray();

            //For handling Null exception
            if (value > 0 && value < 1000000001)
            {
                if (len >= 4)
                {
                    int count = 0;

                    for (int i = 0; i < len; i++)
                    {
                        for (int j = len - 1; j > i; j--)
                        {
                            count++;
                            if (count == 3 || count == 6)
                            {
                                chrArray[j - 1] = ',';
                            }
                            else
                            {
                                chrArray[len - 1] = chrArray[j];
                            }
                            len--;
                            i++;

                        }
                    }
                    res = new string(chrArray);
                    return res;

                }
            }
            else
            {

                throw new ArgumentOutOfRangeException();
            }

            return value.ToString();
        }
    }
}
