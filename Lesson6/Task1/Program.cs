// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string message)
{
    System.Console.WriteLine($"{message}");
    return Convert.ToInt32(Console.ReadLine());
}

int[] ArrayEnrty(int count) {
    int[] array = new int[count];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Enter number {i + 1}: ");
    } return array;
}

void Print(int[] array)
{
    System.Console.Write("Our array: ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    } System.Console.WriteLine();
}

int AbobeZero (int[] array) {
    int count = 0;
    foreach (int i in array)
    {
        if(i > 0) count++;
    } return count;
}

string Plural(int number) {
    string word = "numbers";
    if (number == 1) {
        word = "number";
    } return word;
}

int count = Prompt("How many numbers you are going to enter?");
int[] newArray = ArrayEnrty(count);
Print(newArray);
int aboveZero = AbobeZero(newArray);
string plural = Plural(aboveZero);
System.Console.WriteLine($"{aboveZero} {plural} In the array Is more then zero.");
