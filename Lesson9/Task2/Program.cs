// Задача 2: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumOfNaturalElements(int m, int n)
{
    if (n == m)
    {
        return n;
    }
    return n + SumOfNaturalElements(m, n - 1);
}

System.Console.WriteLine(SumOfNaturalElements(1, 15));
System.Console.WriteLine(SumOfNaturalElements(4, 8));
System.Console.WriteLine(SumOfNaturalElements(1, 100));