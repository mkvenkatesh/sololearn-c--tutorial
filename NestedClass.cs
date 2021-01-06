using System;

//C# supports nested classes: a class that is a member of another class. A
//nested class acts as a member of the class, so it can have the same access
//modifiers as other members (public, private, protected). 

class Car {
    string name;
    public Car(string nm) {
        this.name = nm;
        Console.WriteLine("Car class with an object of name: {0}", this.name);
        Motor m = new Motor();        
    }

    // nested class
    public class Motor {
        int hp = 746;
        public Motor() {
            Console.WriteLine("Motor nested class inside Car. Horsepower is: {0}", this.hp);
        }
    }
}