Console.Clear();
Console.Write("Введите первое  число");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
	Console.WriteLine("Самое большое число здесь: " + a);
}
else 
{
	Console.WriteLine("Самое большое число здесь: " + b);
}
