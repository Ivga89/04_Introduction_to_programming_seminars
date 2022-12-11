// Задача 3: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. . Не использовать строки
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.Write("Enter any number: ");
int input = Convert.ToInt32(Console.ReadLine());
int count = 1;
int n = input;
int desValue = 0;

while(input > 9) {
    input = input / 10;
    count++;
}

switch(count) {
    case 1: System.Console.WriteLine("The third digit does not exist"); break;
    case 2: System.Console.WriteLine("The third digit does not exist"); break;
    case 3: desValue = n % 10; System.Console.WriteLine($"The third digit is {desValue}"); break;
    case 4: desValue = (n / 10) % 10; System.Console.WriteLine($"The third digit is {desValue}"); break;
    case 5: desValue = (n / 100) % 10; System.Console.WriteLine($"The third digit is {desValue}"); break;
    case 6: desValue = (n / 1000) % 10; System.Console.WriteLine($"The third digit is {desValue}"); break;
    case 7: desValue = (n / 10000) % 10; System.Console.WriteLine($"The third digit is {desValue}"); break;
    case 8: desValue = (n / 100000) % 10; System.Console.WriteLine($"The third digit is {desValue}"); break;
    case 9: desValue = (n / 1000000) % 10; System.Console.WriteLine($"The third digit is {desValue}"); break;
    case 10: desValue = (n / 10000000) % 10; System.Console.WriteLine($"The third digit is {desValue}"); break;
}