// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
static int GetPow(int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
        result = result * a;
        Console.WriteLine($"{result = result * a}");
    }
    return result;
}


Console.WriteLine("Введите два числа (A и B):");

Console.Write("A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("B: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = GetPow(a, b);

Console.WriteLine($"{a}^{b} = {result}");




