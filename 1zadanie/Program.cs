Console.Clear();
Console.Write("Введите первое  число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b){
	Console.WriteLine("Вы написали одинаковые числа");
}
else{
	if (a > b)
	{
		Console.WriteLine("Максимальное число: " + a + " Минимальное число: " + b);
	}
	else
	{
		Console.WriteLine("Самое большое число здесь: " + b + " Минимальное число: " + a);
	}
}