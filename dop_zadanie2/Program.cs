//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
Console.Clear();
Console.WriteLine("Программа позволяет выдать название недели по заданному номер от 1 до 7 ");
Console.Write("Введите число от 1 до 7: ");
int b = Convert.ToInt32(Console.ReadLine());
if(1 <= b && b <= 7) {
	if (b == 1) Console.WriteLine("Это понедельник");
	if (b == 2) Console.WriteLine("Это вторник");
	if (b == 3) Console.WriteLine("Это среда");
	if (b == 4) Console.WriteLine("Это Четверг");
	if (b == 5) Console.WriteLine("Это Пятница");
	if (b == 6) Console.WriteLine("Это Суббота");
	if (b == 7) Console.WriteLine("Это Воскресенье");
}
else{
	Console.WriteLine("Вот Шалун! Я же попросил, от 1 до 7) Давай заново!");
}
