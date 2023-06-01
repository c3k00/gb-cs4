
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень:");
int st = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{number}^{st} = {(long)Math.Pow(number, st):N0}");