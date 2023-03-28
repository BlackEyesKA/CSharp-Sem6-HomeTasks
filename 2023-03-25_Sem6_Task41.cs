// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Clear();
int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.WriteLine($"[{string.Join(", ", array)}]");
int count = 0;
foreach (int elem in array)
{
    if (elem > 0) count++;
}
Console.WriteLine($"кол-во чисел > 0 = {count}");