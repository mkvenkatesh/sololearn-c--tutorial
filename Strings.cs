using System;

// sealed modifier makes it so that inheritance is blocked. No derived classes
// are possible
sealed class Strings {
    public static void StringDemo() {
        string s = "Hello, World!";

        // Length
        Console.WriteLine("\nLength of string s is: {0}", s.Length);

        // IndexOf
        Console.WriteLine("IndexOf ',' is: " + s.IndexOf(","));

        // Insert
        Console.WriteLine("Insert 'Venkatesh' between Hello & World: " + s.Insert(6, " Venkatesh,"));

        // Replace  
        Console.WriteLine("Repace 'World' with 'Word': " + s.Replace("World", "Word"));

        // Contains
        Console.WriteLine("Does string '{0}' contain 'Hell'?: {1}", s, s.Contains("Hell"));

        // Remove
        Console.WriteLine("Remove everything after 'Hello' from string '{0}': {1}", s, s.Remove(s.IndexOf(",")));

        // Substring
        Console.WriteLine("Return 'World' from string '{0}': {1}", s, s.Substring(s.IndexOf(" ")));
    }
}