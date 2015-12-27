using System;
using System.Linq;

namespace Kata1_palindrome
{
    public static class PalindromeExtension
    {
        public static bool IsPalindrome(this string str)
        {
            if(str == null) throw new ArgumentNullException("value");
            str = string.Join("", str.Where(char.IsLetterOrDigit).Select(char.ToLower));
            for (var i = 0; i < str.Length/2; i++)
            {
                if (char.ToLower(str[i]) != char.ToLower(str[str.Length - i - 1]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
