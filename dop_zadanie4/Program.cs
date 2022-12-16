// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
Console.Clear();
Console.WriteLine("Программа принимает на вход трёхзначное число и на выходе показыват последнюю цифру этого числа ");
Console.WriteLine("Введите трёхзначное число: ");
int b = Convert.ToInt32(Console.ReadLine());
string e = Convert.ToString(b);
Console.WriteLine($"Последняя цифра: {e[2]}");