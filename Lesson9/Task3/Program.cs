// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// A(m,n) : n + 1                     m = 0
//        : A (m - 1, 1)              m > 0, n = 0
//        : A (m - 1, A (m, n - 1))   m > 0, n > 0

int AckermannFunction (int m, int n) {
    if (m == 0) {
        return n + 1;
    }
    if (m > 0 && n == 0) {
        return AckermannFunction (m - 1, 1);
    }
    if (m > 0 && n > 0) {
        return AckermannFunction (m - 1, AckermannFunction (m, n - 1));
    }
    return AckermannFunction(m, n);
}

System.Console.WriteLine(AckermannFunction (2, 3));
System.Console.WriteLine(AckermannFunction (3, 2));
System.Console.WriteLine(AckermannFunction (2, 2));
System.Console.WriteLine(AckermannFunction (3, 3));