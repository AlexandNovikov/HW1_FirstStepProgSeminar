﻿// Задача 3: Напишите программу, которая на вход
// принимает число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).

Console.Write("Введите число для проверки на четность: ");
int num = Console.Read();
if  (num % 2 == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Не четное");
}

