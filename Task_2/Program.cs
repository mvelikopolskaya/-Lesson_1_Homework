Console.Write("Введите значение переменной a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение переменной b = ");
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
Console.Write("max = ");
Console.Write(max);
