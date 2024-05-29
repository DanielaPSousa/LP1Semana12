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

            bool IsPalindromeRecursive(string s, int start, int end)
            {
                if (start >= end)
                {
                    return true;
                }
                if (s[start] != s[end])
                {
                    return false;
                }
                return IsPalindromeRecursive(s, start + 1, end - 1);
            }
            return IsPalindromeRecursive(str, 0, str.Length - 1);
        }    
    }
}

