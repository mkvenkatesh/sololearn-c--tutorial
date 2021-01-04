using System;

class Factorial {
    public static int Fact(int num) {
        if (num == 1) {
            return 1;
        }
        else {
            return num * Fact(num - 1);
        }
    }
}
