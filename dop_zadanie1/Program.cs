//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
Console.Clear();
Console.WriteLine("Программа позволяет проверить, является ли одно число, квадратом второго числа ");
Console.Write("Введите первое число a= ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Второе число b= ");
int b = Convert.ToInt32(Console.ReadLine());
if(a * a == b){
	Console.WriteLine($"Квадрат числа {a} равен {b}");
}
else if(b * b == a){
	Console.WriteLine($"Квадрат числа {b} равен {a}");
}
else{
	Console.WriteLine("Любое число возведённое в квадрат из этих двух, не будет равен второму");
}