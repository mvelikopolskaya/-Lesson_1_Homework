﻿Console.Write("Введите значение переменной a = ");
int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine($"Число {a} - четное");
}
else
{
    Console.WriteLine($"Число {a} - нечетное");
}
