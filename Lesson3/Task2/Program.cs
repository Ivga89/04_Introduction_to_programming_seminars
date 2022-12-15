// Задача 2
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string message)
{
    System.Console.WriteLine($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = Prompt("Enter x1");
int x2 = Prompt("Enter x2");
int x3 = Prompt("Enter x3");
int y1 = Prompt("Enter y1");
int y2 = Prompt("Enter y2");
int y3 = Prompt("Enter y3");
double a = (x1 - x2 - x3) * (x1 - x2 - x3);
double b = (y1 - y2 - y3) * (y1 - y2 - y3);
double vectorAB = Math.Round(Math.Sqrt(a + b), 2);

System.Console.WriteLine($"The distance between points A({x1}, {x2}, {x3}) and B({y1}, {y2}, {y3}) is {vectorAB}.");

