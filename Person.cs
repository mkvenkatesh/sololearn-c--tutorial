using System;

class Person {
    public int age;
    public string name;
    private string gender;

    // protected access modifier for a property. Only the base class and any
    // derived classes can access this property
    protected string Occupation { get; set; } 

    public Person() {
        Occupation = "N/A";
        Console.WriteLine("Person base class object created...");
    }
    public void SayHi() {
        Console.WriteLine("Hi {0}. Your age is {1} and a {2}. Your occupation is {3}.", name, age, gender, Occupation);
    }

    public void SetGender(string sex) {
        gender = sex;
    }
}