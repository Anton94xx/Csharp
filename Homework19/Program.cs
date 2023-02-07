// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
string text = Console.ReadLine();
char[] obrtext = text.ToCharArray();
Array.Reverse(obrtext);
string finaltext = new string(obrtext);
if (text == finaltext)
{
    Console.WriteLine("Является палиндромом");
}
if (text != finaltext)
{
    Console.WriteLine("Не является палиндромом");
}