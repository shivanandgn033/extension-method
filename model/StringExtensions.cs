using System;
namespace extension_method;

public static class StringExtensions
{
    // This is an extension method that adds a custom word count functionality to the string class.
    public static int WordCount(this string str)
    {
        if (string.IsNullOrWhiteSpace(str))
        {
            return 0;
        }

        string[] words = str.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }

    // Another example, to reverse a string.
    public static string Reverse(this string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return str;
        }

        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    //Example to check if a string is a palindrome.
    public static bool IsPalindrome(this string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return true; //Empty strings are considered palindromes.
        }

        string cleanedStr = new string(str.ToLower().Where(char.IsLetterOrDigit).ToArray());
        string reversedStr = cleanedStr.Reverse();

        return cleanedStr.Equals(reversedStr);
    }
}
