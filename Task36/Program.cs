// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    Console.WriteLine("Мвссив: ");
    Console.Write("[ ");
    while (index < length)
    {
        collection[index] = new Random().Next(1, 100);
        Console.Write( collection[index] + " ");
        index++;
    }
    Console.Write("]");
    Console.WriteLine();
    
 }

void PrintArray(int[] print)   
{
    int count = print.Length;
    int position = 0;
    int sum = 0;
Console.WriteLine("Нечетные элементы массива: ");
    while (position < count)
    {
        if (print[position] % 2 != 0)
            Console.Write(print[position] + " ");
        if (print[position] % 2 != 0) sum += print[position];
        position++;
    }
    Console.WriteLine();
    Console.Write("Сумма нечетных элементов массива равна : " + sum);
}
Console.WriteLine("Введите размер массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N]; 

FillArray(array);
PrintArray(array);
