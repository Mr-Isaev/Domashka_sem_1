//Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
Console.Clear();
Console.WriteLine("Программа принимает условное число B, а после выводит все числа от -B до B ");
Console.Write("Любое число: ");
int b = Convert.ToInt32(Console.ReadLine());
int a = -b-1;
while (a < b){
	a++;
	Console.WriteLine(a);
}