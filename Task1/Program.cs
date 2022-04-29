// Задача 1: Напишите программу, которая на вход
// принимает два числа и выдаёт, какое число большее, а
// какое меньшее.

Console.WriteLine("Введите число a: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int num2 = int.Parse(Console.ReadLine());

int max = num1;
if (num2 > max) max = num2;

Console.Write("max= ");
Console.WriteLine(max);