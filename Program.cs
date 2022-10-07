/* Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */
int a;
Console.WriteLine("Введите число");
while (!int.TryParse(Console.ReadLine(), out a))
{
	Console.WriteLine("Не верный ввод. Повторите ввод");
}
for (int i = 1; i <= a; i++)
{
	Console.Write(Math.Pow(i, 3) + " ");
}
