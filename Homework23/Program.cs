// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125



void num (int n)
{
    int count = 1;
    while (count <=n)
    {
        Console.WriteLine($"{count*count*count}");
        count++;
    }
}
Console.WriteLine("Введите положительное число: ");
int number = int.Parse(Console.ReadLine());
num(number);