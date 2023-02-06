// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int count = 0;
while (num > 0) // (num != 0) 
{
    num = num / 10; // num /=10 то же самое.
   count++;
}
Console.WriteLine($"Количество чисел: {count}");
