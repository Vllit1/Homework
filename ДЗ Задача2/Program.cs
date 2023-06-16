//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Input number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Your numbers are {number1},{number2}");
if(number1 > number2)
{
    Console.WriteLine("Большее число:" + number1);
    Console.WriteLine("Меньшее число:" + number2);
}
else
{
    Console.WriteLine("Большее число:" + number2);
    Console.WriteLine("Меньшее число:" + number1);
}