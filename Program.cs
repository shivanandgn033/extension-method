using System;
using extension_method;

//............................................................................................................

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

        //..........................................................................................................................................
    
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

        //......................................................................................................