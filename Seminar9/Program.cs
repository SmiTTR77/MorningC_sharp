// Seminar 9

// Task 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// void ShowNums(int num)
// {
// 	Console.Write(num + " ");
// 	if (num > 1) ShowNums(num - 1);
// 	Console.Write(num + " ");
// }

// ShowNums(5);


// Task 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// int SumOfDigits(int num)
// {
// 	if (num / 10 != 0) return SumOfDigits(num / 10) + Math.Abs(num % 10);
// 	return Math.Abs(num);
// }

// Console.WriteLine(SumOfDigits(-1234));


// ClassWork

// Task 1. Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void ShowNums(int m, int n)
{
	if (m == n) Console.WriteLine(m);
	else
	{
		if (m > n)
		{
			ShowNums(m - 1, n);
			Console.WriteLine(m + " ");
		}
		else
		{
			ShowNums(m + 1, n);
			Console.WriteLine(m + " ");
		}
	}

}

ShowNums(1, 5);
*/

//Task 2. Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B.

double NumPow(int a, double b)
{
	if (b == 0) return 1;
	else
	{
		if (b > 0)
			return NumPow(a, b - 1) * a;
		else
			return NumPow(a, b + 1) / a;
	}
}
Console.WriteLine(NumPow(2, 5));