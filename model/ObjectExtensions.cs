
using System;
namespace extension_method;

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
