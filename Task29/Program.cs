// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
Console.WriteLine("Элементы массива: ");
for (int a = 0; a < array.Length; a++)
{
    array[a] = new Random().Next(10);
    Console.Write(array[a] + ",");
}