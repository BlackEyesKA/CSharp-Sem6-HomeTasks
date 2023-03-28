// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
//
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.Write("Введите значения b1, k1, b2 и k2  ");
double[] a = Console.ReadLine().Split(" ").Select(x => double.Parse(x)).ToArray();
double x = ((a[0] - a[2]) / (a[3] - a[1]));
double[] y = new double[2];
y[0] = a[1] * x + a[0];
y[1] = a[3] * x + a[2];
Console.WriteLine($"y({string.Join(", ", y)})");