// Напишите программу, которая выводит на экран числа от 1 до 100. 
// При этом вместо чисел, кратных трем, программа должна выводить слово «Fizz», 
// а вместо чисел, кратных пяти — слово «Buzz». Если число кратно и 3, и 5,
//  то программа должна выводить слово «FizzBuzz».

int count = 1;
while (count <= 100)
{
    if ((count % 3 == 0) & (count % 5 == 0))
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (count % 3 == 0)
    {
     Console.WriteLine("Fizz");   
    }
    else if (count % 5 == 0)
    {
     Console.WriteLine("Buzz");   
    }
    else
    {
        Console.WriteLine(count);
    }
    count++;
}