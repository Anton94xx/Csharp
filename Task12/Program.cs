// Напишите программу, которая по заданному номеру четверти,
//  показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Номер четверти: ");
int num = int.Parse(Console.ReadLine());

if ((num > 4) || (num < 1))
{
    Console.WriteLine("Нет такой четверти");
}
else
{
    if (num == 1)
    {
        Console.WriteLine("В I четверти x > 0 и y > 0");
    }
    else if (num == 2)
    {
        Console.WriteLine("В II четверти x < 0 и y > 0");
    }
    else if (num == 3)
    {
        Console.WriteLine("В III четверти x < 0 и y < 0");
    }
    else if (num == 4)
    {
        Console.WriteLine("В IV четверти x > 0 и y < 0");
    }
}