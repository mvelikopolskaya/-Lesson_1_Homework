Console.Write("Введите переменную a = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите переменную b = ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите переменную c = ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if ((a > b) && (a > c)) max = a;
else if ((b > a) && (b > c)) max = b;
else
{
    max = c;
}
Console.WriteLine(max);