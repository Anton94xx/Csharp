// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

int sum = 0;
for (int i = m; i <= n; i++)
{
    if (i > 0)
    {
        sum += i;
    }
}

Console.WriteLine($"Сумма натуральных чисел от {m} до {n}: {sum}");

Console.ReadLine();