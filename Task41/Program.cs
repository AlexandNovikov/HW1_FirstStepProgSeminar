// задача 41
//Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine();
int volume = 10;                // колчество ввода чисел
int count = 0;

while (volume > 0)
{
    Console.Write("Введите 10 чисел через Enter:   ");
    string num = Console.ReadLine();
    int number = Convert.ToInt32(num);
    if (number > 0) count++;
    volume--;
}

Console.WriteLine($"Вы ввели {count} чисел больше 0");