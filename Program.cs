/*
//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Clear();

Console.Write("Введите число N: ");
int N = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите число M: ");
int M = Convert.ToInt16(Console.ReadLine());
if (M>N)
for (int i = N; i <= M; i++)
    Console.Write($" {i}");
else
    for (int i = M; i <= N; i++)
        Console.Write($" {i}");




//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();

int m = Input("Введите число M:");
int n = Input("Введите число N:");
Console.WriteLine($"Сумма элементов от {m} до {n} = {Sum(m, n)}");
	
int Input(string output)
	{
	    Console.Write(output);
	    return int.Parse(Console.ReadLine());
	}
	
int Sum(int m, int n)
	{
	    if (m == n)
	        return n;
	    return n + Sum(m, n - 1);
	}


// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
		
Console.Clear();


Console.Write("Введите число n: ");
int n = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите число m: ");
int m = Convert.ToInt16(Console.ReadLine());

int AkkFunc(int m, int n)
	{
		    if(m == 0)
		{
			return n + 1;
		}
		    if(m > 0 && n == 0)
		{
			return AkkFunc(m - 1, 1);
		}
			return AkkFunc(m - 1, AkkFunc(m, n - 1));
	}
		
Console.WriteLine(AkkFunc(m,n));

*/
