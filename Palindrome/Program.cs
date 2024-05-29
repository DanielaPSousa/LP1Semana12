using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var arg in args)
            {
                bool isPalindrome = IsPalindrome(arg);
                Console.WriteLine($"{arg} -> {isPalindrome}");
            }
        }
        static bool IsPalindrome(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException(nameof(str));
            }
            if (str.Length < 2)
            {
                return true;
            }
        }    
    }
}

