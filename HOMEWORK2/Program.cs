// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите число от 100 до 999: ");
int FirstNmbr = Convert.ToInt32(Console.ReadLine());

int nmbr = (FirstNmbr % 100) / 10;

Console.WriteLine($"{nmbr}");

// ..............................................................................................................................
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число от 100 до 999: ");
int SecondNmbr = Convert.ToInt32(Console.ReadLine());

if (SecondNmbr > 100)
{
    int secondDigit = SecondNmbr % 10;
    Console.WriteLine($"{secondDigit}");
}
else
{
    Console.WriteLine("Третьей цифры нет!");
}

// ..............................................................................................................................
/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Add day");
string numberStr = Console.ReadLine();
int day = Convert.ToInt32(numberStr);

if (day == 1)
{
    Console.WriteLine("Нет!");
}
else if (day == 2)
{
    Console.WriteLine("Нет!");
}
else if (day == 3)
{
    Console.WriteLine("Нет!");
}
else if (day == 4)
{
    Console.WriteLine("Нет!");
}
else if (day == 5)
{
    Console.WriteLine("Нет!");
}
else if (day == 6)
{
    Console.WriteLine("Да!");
}
else if (day == 7)
{
    Console.WriteLine("Да!");
}
else
{
    Console.WriteLine("Это не день недели!");
}
