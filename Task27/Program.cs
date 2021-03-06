// Задача 27: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int sumDigit = SumNum(number);

Console.WriteLine("Сумма цифр в числе: " + SumNum(number));

int SumNum(int number)
{
    int rem = 0;
    int sumDigit = 0;

    while (number > 0)
    {
        rem = number % 10;
        sumDigit = sumDigit + rem;
        number = number / 10;
    }

    return sumDigit;
}
