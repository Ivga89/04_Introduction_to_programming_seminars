// Задача 3: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет. . Не использовать строки
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.Write("Enter any number: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n >= 100 && n < 1000) {    //проверяем есть ли третья цифра
    int unit = n % 10;
    System.Console.WriteLine($"The third digit of number {n} is {unit}.");
}
else if (n > 999) {
    System.Console.WriteLine("Not such a big number, please!"); //если проверяем третью цифру с лева направо, 
}                                                                   //очень много проверять 'сколькизначное' число
else {
    System.Console.WriteLine("The third digit does not exist.");
}