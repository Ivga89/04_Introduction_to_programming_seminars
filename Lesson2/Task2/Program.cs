// Задача 2: Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа. Не использовать строки для расчета

// 456 -> 46
// 782 -> 72
// 918 -> 98

System.Console.Write("Enter a three-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n >= 100 && n < 1000) {    //проверяем трехзначное ли число
    int ten = (n / 100) * 10; 
    int unit = n % 10;
    System.Console.WriteLine($"If you remove a middle digit from number {n} you get {ten + unit}.");
}
else {
    System.Console.WriteLine("You entered not a three-digit number.");
}