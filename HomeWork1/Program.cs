//HomeWork 1

//Task 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
	Console.Write("Max = " + num1 + " Min = " + num2);
}
else
{
	Console.Write($"Max = {num2}, Min = {num1}");
}
*/


//Task 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int current = 0;

if (num1 > num2)
	current = num1;
else
	current = num2;

if (current > num3)
	Console.Write($"Max = {current}");
else
	Console.Write($"Max = {num3}");
*/


//Task 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
	Console.Write("Yes");
else
	Console.Write("No");
*/


//Task 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*
Console.Write("Please, enter any natural number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 1;

if (num > 1)
{
	while (current <= num)
	{
		if (current % 2 == 0)
		{
			Console.Write(current + " ");
			current++;
		}
		else
			current++;
	}
}
else
	Console.Write("No numbers found");
*/