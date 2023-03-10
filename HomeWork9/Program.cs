// HomeWork 9

//Task 64. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
/*
void ShowNums(int num)
{
	if (num > 0)
	{
		Console.Write(num + " ");
		if (num > 1) ShowNums(num - 1);
	}
	else Console.WriteLine("Your number is not a natural. Please try again");
}

Console.Write("Input value N: ");
ShowNums(Convert.ToInt32(Console.ReadLine()));
*/

//Task 66. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumOfDigits(int numberM, int numberN)
{
	if (numberM > 0 && numberN > 0)
	{
		if (numberM < numberN) return numberM + SumOfDigits(numberM + 1, numberN);
		if (numberM > numberN) return numberM + SumOfDigits(numberM - 1, numberN);
		else return numberM;
	}
	return -1;
}

Console.Write("Input value M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input value N: ");
int numN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Your result: {SumOfDigits(numM, numN)}");
*/

// Task 68. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AkkermanFunction(int valueM, int valueN)
{
	if (valueM >= 0 && valueN >= 0)
	{
		if (valueM == 0) return valueN + 1;
		if (valueN == 0) return AkkermanFunction(valueM - 1, 1);
		else return AkkermanFunction(valueM - 1, AkkermanFunction(valueM, valueN - 1));
	}
	return -1;
}

Console.Write("Input value M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input value N: ");
int numN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Your result: {AkkermanFunction(numM, numN)}");