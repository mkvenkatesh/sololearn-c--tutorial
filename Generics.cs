// <T> is our generic data type below, you can now pass string, int,
// double..pretty much any data type you want and the code handles it. There's
// no need to do method overloading for different data types for the method
// below to handle multiple data types.

// Generics allow the reuse of code across different types.

class Generics {
    public static void Swap<T>(ref T a, ref T b) {
        T temp = a;
        a = b;
        b = temp;
    }
}

class Stack<T> {
    int index = 0;
    T[] innerArray = new T[100];

    public void Push(T item) {
        innerArray[index++] = item;
    }

    public T Pop() {
        return innerArray[--index];
    }

    public T Get(int k) {
        return innerArray[k];
    }
}