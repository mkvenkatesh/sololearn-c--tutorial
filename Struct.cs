// A struct type is a value type that is typically used to encapsulate small
// groups of related variables, such as the coordinates of a rectangle or the
// characteristics of an item in an inventory. Structs do not support
// inheritance and cannot contain virtual methods. Structs are best suited for
// small data structures that is not intended to be modified after creating the
// struct. Classes are for modeling complex objects/behaviors.

// All standard C# types (int, double, bool, char, etc.) are actually structs.
struct Book {
    public string title;
    public string author;
    public double price;
    public Book(string title, string author, double price) {
        this.title = title;
        this.author = author;
        this.price = price;
    }
}