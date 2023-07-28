// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки: ");
int AX = int.Parse(Console.ReadLine()!);
int AY = int.Parse(Console.ReadLine()!);
int AZ = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты второй точки: ");
int BX = int.Parse(Console.ReadLine()!);
int BY = int.Parse(Console.ReadLine()!);
int BZ = int.Parse(Console.ReadLine()!);

double AB = Math.Sqrt(Math.Pow(AX-BX,2) + Math.Pow(AY-BY, 2) + Math.Pow(AZ-BZ, 2));
Console.WriteLine($"Расстояние: {AB:f2}");