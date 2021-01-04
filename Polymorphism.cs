// Polymorphism is one method having different implementations. This happens
// during class inheritance when multiple classes are dervied from a base class
// and they all have the same method name but different definitions. 'virtual'
// keyword on the method for the base class signifies that the method can be
// overloaded in dervied class. For the derived classes, 'override' keyword must
// be added to the method declaration to override the base class implementation.

// To implement polymorphism in the code, you create objects of the base type,
// but instantiate them as derived type

// Shape c = new Circle();
// c.Draw();

using System;

class Shape {
    // virtual specifies that dervied classes can override this method
    // implementation which is the concept of polymorphism
    public virtual void Draw() {
        Console.WriteLine("Drawing shape in base class.");
    }
}

// dervied class
class Square : Shape {
    // override keyword has to be used in derived classes to override base class
    // definitions for this method
    public override void Draw() {
        Console.WriteLine("Drawing shape in Square derived class.");
    }
}

// dervied class
class Circle : Shape {
    // override keyword has to be used in derived classes to override base class
    // definitions for this method    
    public override void Draw() {
        Console.WriteLine("Drawing shape in Circle derived class.");
    }
}