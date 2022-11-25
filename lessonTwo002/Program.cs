// программа, которвя выводит рандом от 10 до 99 и показывает наибольшую цифру числа.

Random rnd = new Random();
int nmbr = rnd.Next(10, 100);
int firstDigit = nmbr / 10;
int secondDigit = nmbr % 10;

Console.WriteLine($"Рандомное число: {nmbr}");

if (firstDigit > secondDigit)
{
    Console.WriteLine($"{firstDigit} больше чем {secondDigit}");
}
else if (secondDigit > firstDigit)
{
    Console.WriteLine($"{secondDigit} больше чем {firstDigit}");
}
else
{
    Console.WriteLine("Числа равны");
}
