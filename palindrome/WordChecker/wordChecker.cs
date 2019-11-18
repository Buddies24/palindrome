using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome.WordChecker
{
    public static class wordChecker
    {
        public static bool IsPalindrome(string word)
        {
            return word.SequenceEqual(word.Reverse());
        }
    }
}
