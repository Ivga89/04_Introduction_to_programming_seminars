// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным. Не использовать строки

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.Write("Enter the number of the day of the week from 1 to 7: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n >= 1 && n <= 5)
{
    System.Console.WriteLine("The day is working.");
}

else if (n == 6 || n == 7)
{
    System.Console.WriteLine("The day is off.");
}

else
{
    System.Console.WriteLine("The number of the day is wrong!");
}