// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Не использовать строки
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)
{
    System.Console.WriteLine($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

void Paladron(int n)
{
    if ((n / 10000) == (n % 10) & ((n / 1000) % 10) == ((n % 100) / 10))
    {
        System.Console.WriteLine("The number is a paladron");
    }
    else
    {
        System.Console.WriteLine("The number is not a paladron");
    }
}

int n = Prompt("Enter a five-digit number");
if (n >= 10000 && n < 99999)
{
    Paladron(n);
}
else
{
    System.Console.WriteLine("You entered not a five-digit number!");
}