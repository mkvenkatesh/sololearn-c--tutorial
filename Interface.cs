// An interface is a completely abstract class, which contains only abstract
// members. 

// public interface IShape 
// { 
// 	void Draw(); 
// }

// All members of the interface are by default abstract, so no need to use the
// abstract keyword. Also, all members of an interface are always public, and no
// access modifiers can be applied to them. It is common to use the capital
// letter I as the starting letter for an interface name. Interfaces can contain
// properties, methods, etc. but cannot contain fields (variables).

// When a class implements an interface, it must also implement, or define, all
// of its methods. The term implementing an interface is used (opposed to the
// term "inheriting from") to describe the process of creating a class based on
// an interface. The interface simply describes what a class should do. The
// class implementing the interface must define how to accomplish the behaviors.
// Override keyword is not required in the interface implemention.

// Advantage of interface over abstract classes is that, you can only derive a
// class from one base class, but you can implement multiple interfaces like below
// class Nitrogen : IElement, IAtom, IMolecule { }

using System;

public interface IElement {
    void AtomicNumber();
}

public interface IAtom {
    void ProtonCount();
}

class Nitrogen : IElement, IAtom {
    public void AtomicNumber() {
        Console.WriteLine("Nitrogen atomic number is 11.");
    }

    public void ProtonCount() {
        Console.WriteLine("Nitrogen proton count is 10.");
    }
}

class Oxygen : IElement, IAtom {
    public void AtomicNumber() {
        Console.WriteLine("Oxygen atomic number is 6.");
    }

    public void ProtonCount() {
        Console.WriteLine("Oxygen proton count is 5.");
    }
}