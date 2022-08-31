using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {

        public bool IsAPalindrome(string input)
        {
            var org = input.Replace(" ", "").ToLower();
            var rev = input.Replace(" ", "").ToLower().Reverse().ToArray();
            return org == new string(rev);
        }
    }
}
