// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

void Mass(int n)
{
    int[] num = new int[n];
    int r = 0;
    for (int i = 0; i < num.Length; i++)
    {
        int Val = new Random().Next(-10, 10);
        
        Console.Write($"{Val} ");
        
        if (Val > 0)
        {
            r++;
        }
        
    }
    Console.WriteLine("");
    Console.Write($"Цифр больше 0: {r} штук(и).");
}

Console.Write("Сколько чисел вывести: ");
int Value = int.Parse(Console.ReadLine()!);
Mass(Value);