// программа, которая выводит рандом от 10 до 99 и показывает наибольшую цифру числа.

// Random rnd = new Random();
// int nmbr = rnd.Next(10, 100);
// int firstDigit = nmbr / 10;
// int secondDigit = nmbr % 10;

// Console.WriteLine($"Рандомное число: {nmbr}");

// if (firstDigit > secondDigit)
// {
//     Console.WriteLine($"{firstDigit} больше чем {secondDigit}");
// }
// else if (secondDigit > firstDigit)
// {
//     Console.WriteLine($"{secondDigit} больше чем {firstDigit}");
// }
// else
// {
//     Console.WriteLine("Числа равны");
// }

// ................................................................................

// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// Random rnd = new Random();
// int nmbr = rnd.Next(10, 1000);

// Console.WriteLine($"Рандомное число: {nmbr}");

// int firstDigit = nmbr / 100;
// int secondDigit = nmbr % 10;

// Console.WriteLine($"{firstDigit}{secondDigit}");

// .................................................................................

// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Console.WriteLine("Add first number: ");
// int FirstNmbr = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Add second number: ");
// int SecondNmbr = Convert.ToInt32(Console.ReadLine());

// int result = FirstNmbr % SecondNmbr;

// if (result == 0)
// {
//     Console.WriteLine($"{FirstNmbr} кратно {SecondNmbr}!");
// }
// else
// {
//     Console.WriteLine($"Остаток {result}.");
// }

// ...............................................................................

//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// Console.Write("Add  number: ");
// int FirstNmbr = Convert.ToInt32(Console.ReadLine());

// if (FirstNmbr % 7 == 0 && FirstNmbr % 23 == 0)
// {
//     Console.WriteLine("Yes!");
// }
// else
// {
//     Console.WriteLine("No!");
// }

// ................................................................................

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Add first number: ");
int FirstNmbr = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Add second number: ");
int SecondNmbr = Convert.ToInt32(Console.ReadLine());

if (FirstNmbr * FirstNmbr == SecondNmbr || SecondNmbr * SecondNmbr == FirstNmbr)
{
    Console.WriteLine("Является!");
}
else
{
    Console.WriteLine("No!");
}
