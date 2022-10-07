/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */
int[] a = new int[3];
int[] b = new int[3];
Console.WriteLine("Введите координату Х первой точки");
while (!int.TryParse(Console.ReadLine(), out a[0]))
{
	Console.WriteLine("Не верный ввод. Повторите");
}
Console.WriteLine("Введите координату Y первой точки");
while (!int.TryParse(Console.ReadLine(), out a[1]))
{
	Console.WriteLine("Не верный ввод. Повторите");
}
Console.WriteLine("Введите координату Z первой точки");
while (!int.TryParse(Console.ReadLine(), out a[2]))
{
	Console.WriteLine("Не верный ввод. Повторите");
}
Console.WriteLine("Введите координату Х второй точки");
while (!int.TryParse(Console.ReadLine(), out b[0]))
{
	Console.WriteLine("Не верный ввод. Повторите");
}
Console.WriteLine("Введите координату Y второй точки");
while (!int.TryParse(Console.ReadLine(), out b[1]))
{
	Console.WriteLine("Не верный ввод. Повторите");
}
Console.WriteLine("Введите координату Z второй точки");
while (!int.TryParse(Console.ReadLine(), out b[2]))
{
	Console.WriteLine("Не верный ввод. Повторите");
}

double lengthAtoB = Math.Sqrt(Math.Pow(a[0] - b[0], 2) + Math.Pow(a[1] - b[1], 2) + Math.Pow(a[2] - b[2], 2));
Console.WriteLine("Расстояние между точками = " + Math.Round(lengthAtoB, 2));