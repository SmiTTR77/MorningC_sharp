// Seminar 4
// Цикл "for()" содержит 3 сегмента и подразумивает добавление вспомогательных локальных данных
// Блок инициализации рабочей переменной может быть множественный:
// for(int i = 0, int j = 10; i < j && j>0; i++, j-=2)
// ";" - разделяет сегменты
// "," - разделяет переменные внутри сигмента
// НО условие может быть только единственное и логическое, допускается "&&" и "||"
// Цикл "for()" освобождает память после использования переменных указанных в блоке инициализации "убирает за собой"
// Можно использовать только один сегмент, но разделение необходимо оставлять:
// for(; i<num;)
// Рабочая переменнвя - это переменная которая используется дополнительно внутри цикла
// если таие переменные отсутствуют логичнее использовать цикл "while()"
// При работе с массивами всегда, как правило, используется цикл "for()"
// Из усовий "for()" нельзя возвращать


// Task 1. Напишите программу, которая на вход принимает число (А) и выдаёт сумму чисел от 1 до (А)
/*
int GetSum(int a)
{
	int sum = 0;
	for (int current = 1; current <= a; current++)
		sum += current;
	return sum;
}

Console.WriteLine("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = GetSum(number);
Console.WriteLine($"Sum of numbers for 1 to {number} is {result}");
*/

// Таже запись для while
/*
int current =1;
while(ConcurrentExclusiveSchedulerPair <= a)
{
	sum+=current;
	current++;
}
*/


// Массивы

// int [] - одномерный массив
// int [,] - двумерный (многомерный) массив

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
	int[] array = new int[size];

	for (int i = 0; i < size; i++)
	{
		array[i] = new Random().Next(minValue, maxValue + 1);
	}
	return array;
}

void ShowArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
		Console.Write(array[i] + " ");
	Console.WriteLine();
}

Console.Write("Input a quantity of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a min posimble value: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a max posimble value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);

// ClassWork

// Task 1. Напишите программу, которая принимает на вход число и выдаёт колличество цифр в числе
/*
int DigitNumbers(int number)
{
	int counter = 0;

	if (number == 0) counter = 1;
	for (; number > 0; counter++)
		number /= 10;
	return counter;
}

Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = DigitNumbers(num);
Console.WriteLine($"Numbers digits {result}");
*/


// Task 2. Напишите программу которая принимает на вход число N и выдаёт произведение числ от 1 до N
/*
int FindFactorial(int number)
{
	int factorial = 1;

	if (number == 0) factorial = 1;

	for (int current = 1; current <= number; current++)
	{
		factorial *= current;
	}
	return factorial;
}

Console.WriteLine("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = FindFactorial(num);
Console.WriteLine($"Factorial {num} is {result}");
*/