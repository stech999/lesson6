// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

Console.Clear();

int Prompt(string msg) // сверка на буквы
{
    Console.Write(msg);
    string value = Console.ReadLine()!;
    if ((int.TryParse(value, out int val)) == false)
    {
        Console.WriteLine("Это не число ");
    }
    return val;
}
  
void Level(int b1, int k1, int b2, int k2)
{
    double BB1 = b1;
    double BB2 = k1;
    double KK1 = b2;
    double KK2 = k2;

    double x = (BB2 - BB1) / (KK1 - KK2);
    double y = (KK1 * (BB2 - BB1)) / (KK1 - KK2) + BB1;
    Console.Write($"x = {x}");
    Console.WriteLine();
    Console.Write($"y = {y}");
}

int ValueB1 = Prompt("Введите число b1: ");
int ValueK1 = Prompt("Введите число k1: ");
int ValueB2 = Prompt("Введите число b2: ");
int ValueK2 = Prompt("Введите число k2: ");
Level(ValueB1, ValueB2, ValueK1, ValueK2);