﻿ //Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите 3 числа, нажимая клавишу Enter после каждого:");

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if(b > max)
{
    max = b;
}
if(c > max)
{
    max = c;
}

Console.WriteLine("Наибольшее число:" + max);