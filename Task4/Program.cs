// Задача 4: Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.


Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int start = 0;
while (start <= num)
{

        if  (start % 2 == 0)
{
        Console.Write(start+", ");

}
    start++;
    }
