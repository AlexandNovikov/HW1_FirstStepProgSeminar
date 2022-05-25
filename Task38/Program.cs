// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
Console.WriteLine();

int size = new Random().Next(1, 11);

Console.WriteLine($"Количетсов элементов массива: {size}");

double[] FillArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(); //* 100;
    }
    return array;
}

void PrintDiffMinMax(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
    double difference = 0;
        difference = arr.Max() - arr.Min();
    Console.WriteLine($"Минимальное значение массива {arr.Min()}, максимальное значение массива {arr.Max()}");
    Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет {difference}");
    Console.WriteLine();
}

PrintDiffMinMax(FillArray(size));
Console.WriteLine();

// Console.Clear();
// Console.WriteLine();

// double size = new Random().Next(1, 11);

// Console.WriteLine($"Количетсов элементов массива: {size}");

// double[] FillArray(int size)
// {
//     double[] array = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next();
//     }
//     return array;
// }

// void PrintDiffMinMax(double[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.WriteLine(arr[i]);
//     }
//     double difference = 0;
//     difference = arr.Max() - arr.Min();
//     Console.WriteLine($"Минимальное значение массива {arr.Min()}, максимальное значение массива {arr.Max()}");
//     Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет {difference}");
//     Console.WriteLine();
// }

// PrintDiffMinMax(FillArray(size));
// Console.WriteLine();