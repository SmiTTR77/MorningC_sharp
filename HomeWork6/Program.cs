//HomeWork 6
//Task 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int[] CreateArray()
{
	Console.Write("Input a quantity of elements: ");
	int size = Convert.ToInt32(Console.ReadLine());

	int[] array = new int[size];

	for (int i = 0; i < size; i++)
	{
		Console.Write("Input a value: ");
		array[i] = Convert.ToInt32(Console.ReadLine());
	}
	return array;
}

void ShowArray(int[] array)
{
	for (int i = 0; i < array.Length; i++)
		Console.Write(array[i] + " ");
	Console.WriteLine();
}

int HowManyNumbers(int[] array)
{
	int counter = 0;
	for (int i = 0; i < array.Length; i++)
		if (array[i] > 0) counter++;
	return counter;
}

int[] newArray = CreateArray();
ShowArray(newArray);
Console.WriteLine($"{HowManyNumbers(newArray)} numbers > 0");
*/

//Task 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

/*
void IntersectionPoint(double b1, double k1, double b2, double k2)
{
	if (k1 == k2 && b1 != b2) Console.WriteLine("the lines are parallel, there are no intersection points");
	else if (k1 == k2 && b1 == b2) Console.WriteLine("the lines coincide, there are an infinite number of intersection points");
	else
	{
		double x = Math.Round(-(b1 - b2) / (k1 - k2), 1);
		double y = Math.Round(k1 * x + b1, 1);
		Console.WriteLine($"Intersection point: ({x};{y})");
	}
}

Console.Write("Input a value  b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a value k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Input a value  b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input a value  k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

IntersectionPoint(b1, k1, b2, k2);
*/





