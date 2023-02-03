﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int result = 0;

if (num < 100)
{
    Console.WriteLine("Не хватает третьего числа: ");
}
else
{
    while (num >= 1000)
    {
        num = num /10;
    }
    result = num % 10;
    Console.WriteLine($"{result}");
}