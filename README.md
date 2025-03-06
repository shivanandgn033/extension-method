### String Extensions

```C#

using System;

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

public class Program
{
    public static void Main(string[] args)
    {
        string sentence = "Hello, world! This is a test.";
        int wordCount = sentence.WordCount();
        Console.WriteLine($"Word count: {wordCount}"); // Output: Word count: 6

        string reversedSentence = sentence.Reverse();
        Console.WriteLine($"Reversed sentence: {reversedSentence}"); // Output: .tset a si sihT !dlrow ,olleH

        string palindrome1 = "racecar";
        string palindrome2 = "A man, a plan, a canal: Panama";
        string notPalindrome = "hello";

        Console.WriteLine($"\"{palindrome1}\" is a palindrome: {palindrome1.IsPalindrome()}"); // Output: "racecar" is a palindrome: True
        Console.WriteLine($"\"{palindrome2}\" is a palindrome: {palindrome2.IsPalindrome()}"); // Output: "A man, a plan, a canal: Panama" is a palindrome: True
        Console.WriteLine($"\"{notPalindrome}\" is a palindrome: {notPalindrome.IsPalindrome()}"); //Output: "hello" is a palindrome: False

        string emptyString = "";
        Console.WriteLine($"Empty string word count: {emptyString.WordCount()}"); // Output: Empty string word count: 0
        Console.WriteLine($"Empty string reversed: {emptyString.Reverse()}"); // Output:
        Console.WriteLine($"Empty string palindrome check: {emptyString.IsPalindrome()}"); //Output: Empty string palindrome check: True

        string nullString = null;
        Console.WriteLine($"Null string word count: {nullString.WordCount()}"); //Output: Null string word count: 0
        Console.WriteLine($"Null string reversed: {nullString.Reverse()}"); // Output:
        Console.WriteLine($"Null string palindrome check: {nullString.IsPalindrome()}"); //Output: Null string palindrome check: True
    }
}
```
### Explanation:

1 static class StringExtensions:

Extension methods must be defined within a static class.
The class name (StringExtensions in this case) is arbitrary.


2 public static int WordCount(this string str):

public static: The method must be public and static.
this string str: The this keyword is crucial. It indicates that this is an extension method for the string class. str is the instance of the string that the method will operate on.
The method then splits the string, removes empty entries, and returns the length of the resulting array, effectively counting the words.
The reverse and isPalindrome methods are also extension methods.

3 How to use it:

Once the StringExtensions class is defined, you can call the WordCount, Reverse, and IsPalindrome methods as if they were built-in methods of the string class.
sentence.WordCount() calls the WordCount method on the sentence string.
The same goes for the reverse and isPalindrome methods.

#### Key Concepts:

Extension Methods: Allow you to add methods to existing types without modifying their original definitions.

this Keyword: Identifies the first parameter of an extension method as the type being extended.

static Class and Method: Essential for defining extension methods.

This example demonstrates how extension methods can make your code more readable and maintainable by adding custom functionality to existing classes.

### Object Extensions
```C#

using System;

public static class ObjectExtensions
{
    // Extension method to check if an object is null.
    public static bool IsNull(this object obj)
    {
        return obj == null;
    }

    // Extension method to check if an object is not null.
    public static bool IsNotNull(this object obj)
    {
        return obj != null;
    }

    // Extension method to safely get the string representation of an object.
    public static string SafeToString(this object obj)
    {
        return obj?.ToString() ?? string.Empty; // Uses null-conditional and null-coalescing operators.
    }

    // Extension method to check if an object is of a specific type.
    public static bool IsOfType<T>(this object obj)
    {
        return obj is T;
    }

    //Extension method that returns the type name of an object.
    public static string GetTypeName(this object obj)
    {
        return obj?.GetType().Name ?? "null";
    }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person { Name = "Alice", Age = 30 };
        object nullObject = null;
        object number = 123;
        object text = "Hello";

        Console.WriteLine($"person is null: {person.IsNull()}"); // Output: person is null: False
        Console.WriteLine($"nullObject is null: {nullObject.IsNull()}"); // Output: nullObject is null: True

        Console.WriteLine($"person is not null: {person.IsNotNull()}"); // Output: person is not null: True
        Console.WriteLine($"nullObject is not null: {nullObject.IsNotNull()}"); // Output: nullObject is not null: False

        Console.WriteLine($"person.SafeToString(): {person.SafeToString()}"); // Output: person.SafeToString(): Person
        Console.WriteLine($"nullObject.SafeToString(): {nullObject.SafeToString()}"); // Output: nullObject.SafeToString():

        Console.WriteLine($"person is Person: {person.IsOfType<Person>()}"); // Output: person is Person: True
        Console.WriteLine($"number is int: {number.IsOfType<int>()}"); // Output: number is int: True
        Console.WriteLine($"text is int: {text.IsOfType<int>()}"); //Output: text is int: False

        Console.WriteLine($"person type name: {person.GetTypeName()}"); //Output: person type name: Person
        Console.WriteLine($"nullObject type name: {nullObject.GetTypeName()}"); //Output: nullObject type name: null
        Console.WriteLine($"number type name: {number.GetTypeName()}"); //Output: number type name: Int32
    }
}
```
### Explanation:

1 static class ObjectExtensions:

As before, extension methods must be in a static class.

2 public static bool IsNull(this object obj):

this object obj: This makes IsNull() an extension method for any object.
It simply checks if the object is null.

3 public static bool IsNotNull(this object obj):

The opposite of IsNull().

4 public static string SafeToString(this object obj):

This is a safer way to get an object's string representation.
obj?.ToString(): Uses the null-conditional operator (?.) to prevent a NullReferenceException if obj is null.
?? string.Empty: Uses the null-coalescing operator (??) to return an empty string if obj is null.

5 public static bool IsOfType<T>(this object obj):

This generic extension method checks if an object is of a specific type T.
It uses the is operator for type checking.

6 public static string GetTypeName(this object obj):

This extension method returns the type name of an object.
It uses the null-conditional operator to handle null objects.

#### Key Improvements and Considerations:

1 Generality: These extensions work with any object, making them very versatile.

2 Null Safety: The SafeToString() and GetTypeName methods handle null values gracefully.

3 Type Checking: The IsOfType<T>() method provides a convenient way to check object types.

4 Readability: These extension methods can make your code more concise and easier to read.

5 Use with Care: While these extensions are useful, avoid overusing them. If you find yourself adding a lot of object extensions, consider whether you should be creating more specific types or interfaces instead.
