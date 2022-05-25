// Задача 29: Напишите программу, которая задаёт массив
// целых чисел и выводит их на экран.
// Размер массива определяется пользователем.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



Console.WriteLine("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());

int[] SetArray(int x)
{
    int[] array = new int[x];
    for (int i = 0; i < x; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
        Console.Write("]");
}

PrintArray(SetArray(N));