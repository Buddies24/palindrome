using palindrome.WordChecker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter word to check : ");
            var wordToCheck=Console.ReadLine();
            if (string.IsNullOrWhiteSpace(wordToCheck))
                throw new ArgumentNullException("The word must not be null.");

        }
    }
}
