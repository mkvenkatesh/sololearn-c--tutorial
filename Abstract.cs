// Polymorphism is used when you have different dervied classes with the same
// method as base class, with different implementations in each class. This is
// achieved through 'virtual' keyword on the method definition in base class and
// 'override' keyword in the method definitions in the derived class. Along with
// create objects of type base but instantiating them with derived class in
// programs.

// In some situations there's no meaningful need for the virtual method (base
// class) to have a separate definition. These methods are defined using the
// 'abstract' keyword and specify that the derived classes must define that
// method on their own. You cannot create objects of a class containing an
// abstract method, which is why the class itself should be abstract. 

// Abstract classes have the following features:
// - An abstract class cannot be instantiated.
// - An abstract class may contain abstract methods and accessors.
// - A non-abstract class derived from an abstract class must include actual
//   implementations of all inherited abstract methods and accessors. 

using System;

abstract class Animal {
    public abstract void Bark();
}

class Horse : Animal {
    public override void Bark() {
        Console.WriteLine("Horse dervied class.");
    }
}

class Griffin : Animal {
    public override void Bark() {
        Console.WriteLine("Griffin dervied class.");
    }
}