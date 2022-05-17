// Задача 21: Напишите программу, которая принимает на
// вход координаты двух точек и находит расстояние между
// ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine("Введите координаты первой точки ");
double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
double z1 = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки ");
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());
double z2 = double.Parse(Console.ReadLine());

Console.WriteLine("расстояние между точками = ");

double distance = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1)+(z2 - z1)*(z2 - z1));
double n = Math.Round(distance, 2); // преобразовывает и округляет до 2 занчения после запятой
Console.WriteLine(n);
