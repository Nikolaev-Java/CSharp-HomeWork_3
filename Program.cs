/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */

int usernumber;
Console.WriteLine("Введите пятизначное число");
while (!int.TryParse(Console.ReadLine(), out usernumber))
{
	Console.WriteLine("Не верный ввод. Повторите");
}
bool palindromCheck = usernumber / 10000 == usernumber % 10 && (usernumber / 1000) % 10 == (usernumber % 100) / 10;
if (palindromCheck)
{
	Console.WriteLine("Число палиндром");
}
else
{
	Console.WriteLine("Число не палиндром");
}