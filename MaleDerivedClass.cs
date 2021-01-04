// This is a dervied class showing the concept of inheritance. The following
// class gets all the public members of the base class plus adds its own
// members.

using System;

class Male : Person {
    public Male(string name = "Mr. NoBody", int age = 0, string ocp = "Male N/A") {
        SetGender("Male");
        this.name = name;
        this.age = age;
        this.Occupation = ocp;
        Console.WriteLine("Male derived class from Person class object created...");
    }

    public void DisplayQualities() {
        Console.WriteLine("This display qualities of a male person.");
    }
}