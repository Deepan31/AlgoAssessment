﻿using System;

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

            if (value > 0 && value < 1000000001)
            {
                int digits = value.ToString().Length;

                if (digits >= 4 && digits < 7)
                {
                    int val = value / 100; //val = 1000 / 100 => 10, 10000/100 => 100, 100000/100 => 1000, 1,000,000 / 10000 => 100
                    int rem = val / 10;   // rem = 10 / 10 => 1,  100 / 10 => 10,000, 1000/10 => 100,000, 100 / 100 => 1

                        res = rem + ",000";

                    return res;

                }
                else if(digits == 7)
                {
                    int val = value / 10000; //val = 1000 / 100 => 10, 10000/100 => 100, 100000/100 => 1000, 1,000,000 / 10000 => 100
                    int rem = val / 100;   // rem = 10 / 10 => 1,  100 / 10 => 10,000, 1000/10 => 100,000, 100 / 100 => 1

                    res = rem + ",000,000";

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
