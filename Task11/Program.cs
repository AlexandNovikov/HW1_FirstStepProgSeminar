// Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 ->  1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("введите число: ");
int number = int.Parse(Console.ReadLine());
int i = 1;

while (i <= number)
{

    {
        NewMethod(i);

    }

    i++;
}

static void NewMethod(int i)
{
    Console.WriteLine($"Число{i,10} | Куб{(int)(i * i * i),10}");
}