// Переменные:
/*
int num = -12; //целочисленное
double bigNum = 67.999; //вещественное 
bool isEven = true; // логическая переменная
string world = "flower 34.76" //строка
char symbol = '$'; // переменная хранящая единственный символ
*/


// Формат записи:
/*
int num1 = 77;
int num2 = 99;

Console.WriteLine("My number is " + num1 + " and " + num2);

Console.WriteLine($"My number is {num1} and {num2}");
*/


// Шаблон:

/*
Console.Write("input an integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("your number is " + num);
*/


// Seminar1 ClassWork

// Task 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
/*
Console.Write("input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int quad = num2 * num2;

if (quad == num1)
{
	Console.Write("yes");
}
else
{
	Console.Write("no");
}
*/


// Task 2. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
/*
Console.Write("Input a positive number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = -num;

while (current <= num)
{
	Console.Write(current + " ");
	current++;
}
*/

// Порядок чисел

//Целочисленное деление

/*
31542 / 10 = 3154
31542 / 100 = 315
31542 / 1000 = 31
31542 / 10000 = 3
*/

// Остаток от деления
/*
31542 % 10 = 2
31542 % 100 = 42
31542 % 1000 = 542
31542 % 10000 = 1542
*/

//Пример: 
/*
453216-> 32
453216 / 100 %100
*/