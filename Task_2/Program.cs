﻿Console.Write("Введите переменную a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите переменную b = ");
int b = Convert.ToInt32(Console.ReadLine());
int max = a;

if (a > b)
{
    max = a;
}
else
{
    max = b;
}

Console.WriteLine($"max = {max}");